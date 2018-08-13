using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Repository;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using iTextSharp.text.html.simpleparser;
using System.Text;

namespace AMDSystems.Controllers
{
    public class IPQuoteController : Controller
    {
        IIPQuotes quoteService;
        IIPQuoteAmounts quoteAmountsService;
        IIPQuoteTaxRates quoteTaxRatesService;
        IIPQuoteItems quoteItemService;
        IIPClients clientService;
        IIPUsers userService;

        public IPQuoteController()
        {
            quoteService = new IPQuotesRepository();
            quoteAmountsService = new IPQuoteAmountsRepository();
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
            quoteItemService = new IPQuoteItemsRepository();
            clientService = new IPClientsRepository();
            userService = new IPUsersRepository();
        }

        // GET: IPQuote
        public ActionResult CreateQuote(int? Client_ID)
        {
            
            IPQuotesModel quoteModel = new IPQuotesModel();
            if(Client_ID.HasValue)
            quoteModel.client_id = Client_ID.Value;
            return View(quoteModel);
        }

        public ActionResult ViewQuotes()
        {
            //IPQuotesModel quoteModel = new IPQuotesModel();
            //return View(quoteModel);       

            var _allProducts = quoteService.FilterIPQuotes();
            return View(_allProducts);
        }





        // GET: IPQuote
        public ActionResult CreateEstimate()
        {
            IPQuotesModel quoteModel = new IPQuotesModel();
            return View(quoteModel);
        }


        public ActionResult ViewEstimate()
        {
            //IPQuotesModel quoteModel = new IPQuotesModel();
            //return View(quoteModel);       

            var _allProducts = quoteService.FilterIPQuotes();
            return View(_allProducts);
        }




       




        [HttpPost]
        public ActionResult CreateQuote(IPQuotesModel model)
        {
            model.type = 0;
            var id =quoteService.Add(model);
            return RedirectToAction("Quote", "IPQuote", new { id = id });
        }

        [HttpGet]
        public ActionResult Quote(int id)
        {
            var quoteModel =  quoteService.FilterIPQuotes(id);
            quoteModel.quote_items = quoteItemService.FilterIPQuoteItems(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.quote_tax_rate = quoteTaxRatesService.FilterIPQuoteTaxRates(quoteModel);
            quoteModel.quote_amount = quoteAmountsService.FilterIPQuoteAmounts(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);

            quoteModel.Client_list = clientService.FilterIPClients();

            return View(quoteModel);
        }

        [HttpPost]
        public ActionResult UpdateQuote(IPQuotesModel model)
        {
            //  model.quote_tax_rate.quote_id = model.quote_id;
            //model.quote_amount.quote_id = model.quote_id;
            if(!string.IsNullOrEmpty(model.quote_date_expires_string))
            {
                model.quote_date_expires = DateTime.ParseExact(model.quote_date_expires_string, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);  
            }
            else
            {
                model.quote_date_expires = DateTime.Now;
            }
            quoteService.UpdateStatus(model);     
            if(model.quote_items!=null)
            quoteItemService.Update(model.quote_items, model.quote_id);
            model.quote_amount.quote_id = model.quote_id;
            quoteAmountsService.Update(model.quote_amount);
            //quoteTaxRatesService.Update(model.quote_tax_rate);
            return RedirectToAction("Quote",new { id = model.quote_id });
        }

        [HttpPost]
        public ActionResult UpdateQuoteItem(IPQuoteItemsModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            quoteService.DeleteQuote(id);
            return RedirectToAction("ViewQuotes", "IPQuote");
        }


        [HttpGet]
        public ActionResult Edit(int quote_id)
        {

            return RedirectToAction("Quote", "IPQuote", new { id = quote_id });
        }

        [HttpGet]
        public FileResult Export()
        {
            string GridHtml;
            GridHtml = getPdfHTMLData().ToString();
            using (MemoryStream stream = new System.IO.MemoryStream())
            {
                StringReader sr = new StringReader(GridHtml);
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                pdfDoc.Close();
                return File(stream.ToArray(), "application/pdf", "Grid.pdf");
            }
        }

        StringBuilder getPdfHTMLData()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<header class='clearfix'>");
            sb.Append("<h1>INVOICE</h1>");
            sb.Append("<div id='company' class='clearfix'>");
            sb.Append("<div>Company Name</div>");
            sb.Append("<div>455 John Tower,<br /> AZ 85004, US</div>");
            sb.Append("<div>(602) 519-0450</div>");
            sb.Append("<div><a href='mailto:company@example.com'>company@example.com</a></div>");
            sb.Append("</div>");
            sb.Append("<div id='project'>");
            sb.Append("<div><span>PROJECT</span> Website development</div>");
            sb.Append("<div><span>CLIENT</span> John Doe</div>");
            sb.Append("<div><span>ADDRESS</span> 796 Silver Harbour, TX 79273, US</div>");
            sb.Append("<div><span>EMAIL</span> <a href='mailto:john@example.com'>john@example.com</a></div>");
            sb.Append("<div><span>DATE</span> April 13, 2016</div>");
            sb.Append("<div><span>DUE DATE</span> May 13, 2016</div>");
            sb.Append("</div>");
            sb.Append("</header>");
            sb.Append("<main>");
            sb.Append("<table>");
            sb.Append("<thead>");
            sb.Append("<tr>");
            sb.Append("<th class='service'>SERVICE</th>");
            sb.Append("<th class='desc'>DESCRIPTION</th>");
            sb.Append("<th>PRICE</th>");
            sb.Append("<th>QTY</th>");
            sb.Append("<th>TOTAL</th>");
            sb.Append("</tr>");
            sb.Append("</thead>");
            sb.Append("<tbody>");
            sb.Append("<tr>");
            sb.Append("<td class='service'>Design</td>");
            sb.Append("<td class='desc'>Creating a recognizable design solution based on the company's existing visual identity</td>");
            sb.Append("<td class='unit'>$400.00</td>");
            sb.Append("<td class='qty'>2</td>");
            sb.Append("<td class='total'>$800.00</td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4'>SUBTOTAL</td>");
            sb.Append("<td class='total'>$800.00</td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4'>TAX 25%</td>");
            sb.Append("<td class='total'>$200.00</td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            sb.Append("<td colspan='4' class='grand total'>GRAND TOTAL</td>");
            sb.Append("<td class='grand total'>$1,000.00</td>");
            sb.Append("</tr>");
            sb.Append("</tbody>");
            sb.Append("</table>");
            sb.Append("<div id='notices'>");
            sb.Append("<div>NOTICE:</div>");
            sb.Append("<div class='notice'>A finance charge of 1.5% will be made on unpaid balances after 30 days.</div>");
            sb.Append("</div>");
            sb.Append("</main>");
            sb.Append("<footer>");
            sb.Append("Invoice was created on a computer and is valid without the signature and seal.");
            sb.Append("</footer>");
            return sb;
        }

      

    }
}