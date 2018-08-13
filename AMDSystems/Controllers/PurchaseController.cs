using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.tool.xml;
using System.Text;

namespace AMDSystems.Controllers
{
    public class PurchaseController : Controller
    {
        IIPPurchase quoteService;
        
        IIPQuoteAmounts quoteAmountsService;
        IIPQuoteTaxRates quoteTaxRatesService;
        IIPQuoteItems quoteItemService;
        IIPClients clientService;
        IIPUsers userService;
        IIPPayments paymentService;

        IIPInvoices invoiceService;

        public PurchaseController()
        {
            quoteService = new IPPurchaseRepository();
            
            quoteAmountsService = new IPQuoteAmountsRepository();
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
            quoteItemService = new IPQuoteItemsRepository();
            clientService = new IPClientsRepository();
            userService = new IPUsersRepository();
            paymentService = new IPPaymentsRepository();
            invoiceService = new IPInvoicesRepository();

        }


        public ActionResult ViewPurchase()
        {
            var invoiceModel = quoteService.FilterIPPurchase();
            return View(invoiceModel);
        }

        [HttpPost]
        public ActionResult CreatePurchase(IPPurchaseModel model)
        {
            model.type = 2;
            var id = quoteService.Add(model);
            return RedirectToAction("Purchase", "Purchase", new { id = id });
        }

        [HttpGet]
        public ActionResult Purchase(int id)
        {
            var quoteModel = quoteService.FilterIPPurchase(id);
            quoteModel.quote_items = quoteItemService.FilterIPQuoteItems(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id,1);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.quote_tax_rate = quoteTaxRatesService.FilterIPQuoteTaxRates(quoteModel);
            quoteModel.quote_amount = quoteAmountsService.FilterIPPurchaseAmounts(quoteModel);
            
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.payment = paymentService.FilterIPPaymentsByQuoteID(id);
            return View(quoteModel);
        }
        [HttpGet]
        public ActionResult Edit(int quote_id)
        {

            return RedirectToAction("Purchase", "Purchase", new { id = quote_id });
        }

        [HttpPost]
        public ActionResult UpdatePurchase(IPPurchaseModel model)
        {
            //  model.quote_tax_rate.quote_id = model.quote_id;
            //model.quote_amount.quote_id = model.quote_id;
            quoteService.Update(model);
            if (model.quote_items != null)
            quoteItemService.Update(model.quote_items, model.quote_id);
            model.quote_amount.quote_id = model.quote_id;
            quoteAmountsService.Update(model.quote_amount);
            if (model.payment != null)
            {
                model.payment.quote_id = model.quote_id;
                paymentService.Update(model.payment);
            }
            //quoteTaxRatesService.Update(model.quote_tax_rate);
            return RedirectToAction("Purchase", new { id = model.quote_id });
        }

        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            quoteService.DeletePurchase(id);
            return RedirectToAction("ViewPurchase", "Purchase", new { id = id });
        }

        // GET: IPInvoices
        public ActionResult CreatePurchase(int? Client_ID)
        {
            IPPurchaseModel quoteModel = new IPPurchaseModel();
            if (Client_ID.HasValue)
                quoteModel.client_id = Client_ID.Value;
            return View(quoteModel);
        }


        public StringBuilder GetClientDetails(int clientID)
        {
            StringBuilder HTMLContent = new StringBuilder();

            var client = clientService.FilterIPClients(clientID);
                       
            HTMLContent.Append(client.Client_Name.ToString()+"<br/>");
            HTMLContent.Append(client.Client_Address_1.ToString()+"<br/>");
            HTMLContent.Append(client.Client_Address_2.ToString()+"<br/>");
            HTMLContent.Append(client.Client_City.ToString()+"<br/>");
            HTMLContent.Append(client.Client_Mobile.ToString()+"<br/>");
           
            return HTMLContent;
        }

	}
}