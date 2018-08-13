using Core_Project.Model;
using Core_Project.Model.StockReport;
using Core_Project.Service;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMDSystems.Controllers
{
    public class ReportsController : Controller
    {
        IIPQuotes quoteService;
        IIPPayments paymentService;
        IIPProducts productService;
        IIPQuoteItems quoteItemsService;

        public ReportsController()
        {
            quoteService = new IPQuotesRepository();
            paymentService = new IPPaymentsRepository();
            productService = new IPProductsRepository();
            quoteItemsService = new IPQuoteItemsRepository();
        }

        public ActionResult InvoiceAging()
        {
            ReportSearch searchModel = new ReportSearch();
            searchModel.startDate = DateTime.MinValue;
            searchModel.endDate = DateTime.MinValue;
            searchModel.ReportVisible = false;
            searchModel.lstQuotes = new List<IPQuotesModel>();
            searchModel.Type = 0;
            return View(searchModel);
        }

        [HttpPost]
        // GET: Reports
        public ActionResult InvoiceAging(ReportSearch searchModel)
        {
            var allQuotes = quoteService.FilterIPQuotes().ToList();
            searchModel.lstQuotes =
                allQuotes
                .Where(q => q.quote_date_created >= searchModel.startDate && q.quote_date_created <= searchModel.endDate && q.type == searchModel.Type);
            searchModel.ReportVisible = true;
            return View(searchModel);

        }

        public ActionResult PaymentHistory()
        {
            ReportSearch searchModel = new ReportSearch();
            searchModel.startDate = DateTime.MinValue;
            searchModel.endDate = DateTime.MinValue;
            searchModel.ReportVisible = false;
            searchModel.lstQuotes = new List<IPQuotesModel>();
            searchModel.lstPayments = new List<IPPaymentsModel>();
            searchModel.Type = 2;
            return View(searchModel);
        }

        [HttpPost]
        public ActionResult PaymentHistory(ReportSearch searchModel)
        {
            if (searchModel.startDate.Equals(DateTime.MinValue) || searchModel.endDate.Equals(DateTime.MinValue))
                return View(searchModel);
            else
            {
                var allQuotes = quoteService.FilterIPQuotes().ToList();
                searchModel.lstQuotes =
                    allQuotes
                    .Where(q => q.quote_date_created >= searchModel.startDate && q.quote_date_created <= searchModel.endDate && q.type == searchModel.Type);
                searchModel.ReportVisible = true;
                return View(searchModel);
            }
        }

        public ActionResult SalesbyClient()
        {
            return View();
        }





        public ActionResult SalesbyDate()
        {
            return View();
        }
        public ActionResult ReportStock()
        {
            ProductDetails productDetails = new ProductDetails();
            return View(productDetails);
        }

        [HttpPost]
        public ActionResult ReportStock(ProductDetails productDetails)
        {
            productDetails = new ProductDetails() { ProductId = 4 };
            if (productDetails != null)
            {
                GetProductTransactions(productDetails);
            }
            return View(productDetails);
        }

        private void GetProductTransactions(ProductDetails productDetails)
        {
            var _lstProductQuoteItems = GetQuoteItemDetails(productDetails);
            if (_lstProductQuoteItems != null && _lstProductQuoteItems.Count > 0)
            {
                Dictionary<int, int> _quoteIdType = GetQuoteDetails(_lstProductQuoteItems);
                if (_quoteIdType.Count > 0)
                {
                    foreach (var _quoteItem in _lstProductQuoteItems)
                    {
                        QuoteItemsDetails _quoteItemsDetails = new QuoteItemsDetails();
                        _quoteItemsDetails.TransactionDate = _quoteItem.item_date_added;
                        _quoteItemsDetails.TransactionQuantity = Decimal.ToInt32(_quoteItem.item_quantity.Value);
                        _quoteItemsDetails.TransactionType = (TransactionType)_quoteIdType[_quoteItem.quote_id];
                        productDetails.Transactions.Add(_quoteItemsDetails);
                    }
                }
                if (productDetails.Transactions.Count > 0)
                {
                    var _lstTransactionsGroup = productDetails.Transactions.GroupBy(t => t.TransactionType).ToList();
                    var _lstPurchaseTransactions = _lstTransactionsGroup.Where(t => t.Key == TransactionType.Purchase).FirstOrDefault();
                    var _purchaseTotal = _lstPurchaseTransactions.Sum(q => q.TransactionQuantity);

                    var _lstInvoiceTransactions = _lstTransactionsGroup.Where(t => t.Key == TransactionType.Invoice).FirstOrDefault();
                    var _invoiceTotal = _lstInvoiceTransactions.Sum(q => q.TransactionQuantity);

                    productDetails.TotalQuantiyInStock = _purchaseTotal - _invoiceTotal;
                }
            }
        }

        private List<IPQuoteItemsModel> GetQuoteItemDetails(ProductDetails productDetails)
        {
            var _lstQuoteItems = quoteItemsService.FilterIPQuoteItems().ToList();
            if (_lstQuoteItems != null && _lstQuoteItems.Count > 0)
            {
                var _lstProductQuoteItems = _lstQuoteItems.Where(q => q.item_product_id == productDetails.ProductId && q.item_date_added > productDetails.StartDate && q.item_date_added < productDetails.EndDate).OrderBy(q => q.item_date_added).ToList();
                if (_lstProductQuoteItems != null && _lstProductQuoteItems.Count > 0)
                {
                    return _lstProductQuoteItems;
                }
            }
            return null;
        }

        private Dictionary<int, int> GetQuoteDetails(List<IPQuoteItemsModel> lstProductQuoteItems)
        {
            var _lstQuoteId = lstProductQuoteItems.Select(q => q.quote_id).Distinct().ToList();
            Dictionary<int, int> _quoteIdType = new Dictionary<int, int>();
            foreach (var _quoteId in _lstQuoteId)
            {
                _quoteIdType.Add(_quoteId, quoteService.GetQuoteType(_quoteId));
            }
            return _quoteIdType;
        }

        [HttpPost]
        public ActionResult RunReport(ProductDetails productDetails)
        {
            if (productDetails != null)
            {
            }
            return View();
        }

        public JsonResult GetAllProducts()
        {
            var _allProducts = productService.FilterIPProducts();
            return Json(_allProducts, JsonRequestBehavior.AllowGet);
        }

    }
}