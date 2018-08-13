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
using System.Collections;

namespace AMDSystems.Controllers
{
    public class IPInvoicesController : Controller
    {
        IIPQuotes quoteService;
        IIPQuoteAmounts quoteAmountsService;
        IIPQuoteTaxRates quoteTaxRatesService;
        IIPQuoteItems quoteItemService;
        IIPClients clientService;
        IIPUsers userService;
        IIPPayments paymentService;
        IIPInvoices invoiceService;

        Hashtable TaxSummarylist;
        bool isIGST;

        public IPInvoicesController()
        {
            quoteService = new IPQuotesRepository();
            
            quoteAmountsService = new IPQuoteAmountsRepository();
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
            quoteItemService = new IPQuoteItemsRepository();
            clientService = new IPClientsRepository();
            userService = new IPUsersRepository();
            paymentService = new IPPaymentsRepository();
            invoiceService = new IPInvoicesRepository();

        }
      
        public ActionResult ViewInvoices()
        {
            var invoiceModel = invoiceService.FilterIPInvoices();
            return View(invoiceModel);
        }


       

        //[HttpPost]
        //[ActionName("DownloadPdf")]
        //public ActionResult DownloadPdf(IPQuotesModel model)
        //{
        //    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 15);
        //    PdfWriter pdfWriter = PdfWriter.GetInstance(pdfDoc, Response.OutputStream);
        //    pdfDoc.Open();

        //    //Top Heading
        //    Chunk chunk = new Chunk("Your Credit Card Statement Report has been Generated", FontFactory.GetFont("Arial", 20, Font.BOLDITALIC, BaseColor.MAGENTA));
        //    pdfDoc.Add(chunk);

        //    //Horizontal Line
        //    Paragraph line = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
        //    pdfDoc.Add(line);

        //    //Table
        //    PdfPTable table = new PdfPTable(2);
        //    table.WidthPercentage = 100;
        //    //0=Left, 1=Centre, 2=Right
        //    table.HorizontalAlignment = 0;
        //    table.SpacingBefore = 20f;
        //    table.SpacingAfter = 30f;

        //}

        [HttpPost]
        public ActionResult CreateInvoice(IPQuotesModel model)
        {
            model.type = 1;
            var id = quoteService.Add(model);
            return RedirectToAction("Invoices", "IPInvoices", new { id = id });
        }

        [HttpGet]
        public ActionResult Invoices(int id)
        {
            var quoteModel = quoteService.FilterIPInvoice(id);
            quoteModel.quote_items = quoteItemService.FilterIPQuoteItems(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.quote_tax_rate = quoteTaxRatesService.FilterIPQuoteTaxRates(quoteModel);
            quoteModel.quote_amount = quoteAmountsService.FilterIPQuoteAmounts(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.payment = paymentService.FilterIPPaymentsByQuoteID(id);
            return View(quoteModel);
        }

        [HttpGet]
        public ActionResult Edit(int quote_id)
        {

            return RedirectToAction("Invoices", "IPInvoices", new { id = quote_id });
        }

        [HttpPost]
        public ActionResult UpdateInvoices(IPQuotesModel model)
        {
            if (!string.IsNullOrEmpty(model.quote_date_expires_string))
            {
                model.quote_date_expires = DateTime.ParseExact(model.quote_date_expires_string, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                model.quote_date_expires = DateTime.Now;
            }
            quoteService.UpdateInvoice(model);
            if (model.quote_items != null)
            quoteItemService.Update(model.quote_items, model.quote_id);
            model.quote_amount.quote_id = model.quote_id;
            quoteAmountsService.Update(model.quote_amount);
            if (model.payment != null)
            {
                model.payment.quote_id = model.quote_id;
                paymentService.Update(model.payment);
            }            
            return RedirectToAction("Invoices", new { id = model.quote_id });
        }

        public ActionResult Payment()
        {
            var quotes = quoteService.FilterIPQuotes();
            foreach (var quote in quotes)
            {
                quote.client = clientService.FilterIPClients(quote.client_id);
                quote.quote_amount = quoteAmountsService.FilterIPQuoteAmounts(quote);
                quote.payment = paymentService.FilterIPPaymentsByQuoteID(quote.quote_id);
            }
            return View(quotes);
        }



        public ActionResult EnterPayment()
        {

            return View();
        }


        public ActionResult ViewPayments()
        {

            return View();
        }

        public ActionResult ViewAllPayments()
        {
            var quotes = quoteService.FilterIPQuotes();
            foreach (var quote in quotes)
            {
                quote.client = clientService.FilterIPClients(quote.client_id);
                quote.quote_amount = quoteAmountsService.FilterIPQuoteAmounts(quote);
                quote.payment = paymentService.FilterIPPaymentsByQuoteID(quote.quote_id);
            }
            return View(quotes);
        }
        
       
        public ActionResult SavePayment(IPPaymentsModel model)
        {
            paymentService.Update(model);
            return Json("true",JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult UpdateInvoicesItem(IPQuoteItemsModel model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            quoteService.DeleteQuote(id);
            return RedirectToAction("ViewInvoices", "IPInvoices", new { id = id });
        }

        // GET: IPInvoices
        public ActionResult CreateInvoice(int? Client_ID)
        {
            IPQuotesModel quoteModel = new IPQuotesModel();
            quoteModel.payment = new IPPaymentsModel();
            if (Client_ID.HasValue)
                quoteModel.client_id = Client_ID.Value;
            return View(quoteModel);
        }

        public ActionResult CreatedInvoice()
        {
            return View();
        }

        //public ActionResult ViewInvoices()
        //{
        //    return View();
        //}

        public ActionResult ViewRecurringInvoices()
        {
            return View();
        }

        public ActionResult CustomInvoice()
        {
            return View();
        }


        public JsonResult Export(string InvoiceNumber, string HTMLcontent, string ClientID, string taxContent, List<String> argTaxList, string argIsIgst)
        {
            string GridHtml;
            GridHtml = HTMLcontent;
                                          
            StringBuilder HTMLbuilder = new StringBuilder();
            HTMLbuilder.Append(HTMLContentBuilder().ToString());

            //HTMLbuilder.Append(GetClientDetails(Convert.ToInt32(ClientID)).ToString());

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");
            //Company Details
            HTMLbuilder.Append("<td>");
            //Company Logo
            HTMLbuilder.Append("<img src=\"" + Server.MapPath("~/Content/") + "logo.jpg\" alt=\"Smiley face\" height=\"150\" width=\"150\"/>");
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("<td class=\"rtl\">");
            HTMLbuilder.Append("Company Name <br/>");
            HTMLbuilder.Append("Address line1 <br/>");
            HTMLbuilder.Append("Address line1 <br/>");
            HTMLbuilder.Append("City <br/>");
            HTMLbuilder.Append("</td>");

            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");
            //Client Details
            HTMLbuilder.Append("<td>");
            HTMLbuilder.Append(GetClientDetails(Convert.ToInt32(ClientID)).ToString());
            HTMLbuilder.Append("</td>");
            // Invoice Details
            HTMLbuilder.Append("<td class=\"rtl\">");
            HTMLbuilder.Append("Invoice Number: " + InvoiceNumber + "<br/>");
            HTMLbuilder.Append("Date: " + System.DateTime.Now.ToString("dd/MM/yyyy") + "<br/>");
            HTMLbuilder.Append("");
            HTMLbuilder.Append("</td>");

            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append(HTMLcontent);
            HTMLbuilder.Append("</table>");
            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append(taxContent);
            HTMLbuilder.Append("</table>");

            
            //TaxSummarylist = argTaxList;
            decimal taxtotal = 0;

            if (argTaxList.Count > 0)
            {
                TaxSummarylist = new Hashtable();

                for(int i =0 ; i < argTaxList.Count ; i++)
                {
                    if (argTaxList[i] != null)
                    {
                        string[] var = argTaxList[i].Split(',');

                        if (!TaxSummarylist.ContainsKey(var[0]))
                        {
                            TaxSummarylist.Add(var[0], var[1]);
                        }
                        else
                        {
                            taxtotal = Convert.ToDecimal(TaxSummarylist[var[0]]);
                            TaxSummarylist.Remove(var[0]);
                            TaxSummarylist.Add(var[0], taxtotal + Convert.ToDecimal(var[1]));
                        }
                    }
                }
            }

            if (Convert.ToInt32(argIsIgst) == 0)
            {
                isIGST = false;
            }
            else
            {
                isIGST = true;
            }

            HTMLbuilder.Append(TaxSummary());
            
            HTMLbuilder.Append("</div>");
            HTMLbuilder.Append("</body>");
            HTMLbuilder.Append("</html>");
            
            GridHtml = HTMLbuilder.ToString();

            StringReader sr = new StringReader(GridHtml);

            System.IO.FileStream fs = new FileStream(Server.MapPath("../Views/IPInvoices/PDF") + "\\" +InvoiceNumber + ".pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
            document.Close();
            writer.Close();
            fs.Close();
            
            JsonResult result = new JsonResult();
            result.Data = InvoiceNumber;
            result.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return result;
        }

        [HttpGet]
        public FileResult Download(string InvoiceNumber)
        {
            //byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("../PDF/" + InvoiceNumber+ ".pdf"));
            string fullPath = Path.Combine(Server.MapPath("../Views/IPInvoices/PDF"), InvoiceNumber + ".pdf");
            string fileName = InvoiceNumber + ".pdf";
            return File(fullPath, "application/pdf", fileName);
        }
        
        [HttpGet]
        public FileResult ViewDownload(int id)
        {

            string GridHtml, HTMLcontent = string.Empty, taxContent = string.Empty,tablecontent = string.Empty;
            
            
            var invoiceModel = quoteService.FilterIPInvoice(id);

            int ClientID = invoiceModel.client_id;
            decimal taxtotal = 0;


            //List<IPQuoteItemsModel> lsQuotesModel = invoiceModel.quote_items.ToList();

            List<IPQuoteItemsModel> lsQuotesModel = new List<IPQuoteItemsModel>();

                    IPQuoteItemsModel quoteitem = new IPQuoteItemsModel();
                    quoteitem.item_name = "Test";
                    quoteitem.item_description = "desc";
                    quoteitem.item_quantity = 15;
                    quoteitem.item_price = 15;
                    quoteitem.item_discount_amount  = 5;
                    quoteitem.item_tax_rate_id = 4;

                    lsQuotesModel.Add(quoteitem);
                    quoteitem = new IPQuoteItemsModel();
                    quoteitem.item_name = "Test";
                    quoteitem.item_description = "desc";
                    quoteitem.item_quantity = 15;
                    quoteitem.item_price = 15;
                    quoteitem.item_discount_amount = 5;
                    quoteitem.item_tax_rate_id = 4;
                    lsQuotesModel.Add(quoteitem);

                    tablecontent = tablecontent + HTMLTableHeader();

                    if (lsQuotesModel.Count > 0)
                    {
                        TaxSummarylist = new Hashtable();
                        
                        foreach (IPQuoteItemsModel quoteitems in lsQuotesModel)
                        {
                            tablecontent = tablecontent + "<tr> ";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_id + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_name + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_description + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_quantity + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_price + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_discount_amount + "</td>";
                            tablecontent = tablecontent + "<td> " + quoteitems.item_tax_rate_id + "</td>";
                            tablecontent = tablecontent + "<td> " + ((quoteitems.item_price * quoteitems.item_quantity) - quoteitems.item_discount_amount).ToString() + "</td>";
                            tablecontent = tablecontent + "</tr> ";

                            if (!TaxSummarylist.ContainsKey(quoteitems.item_tax_rate_id))
                            {
                                TaxSummarylist.Add(quoteitems.item_tax_rate_id, (quoteitems.item_price * quoteitems.item_quantity) - quoteitems.item_discount_amount);
                            }
                            else
                            {
                                taxtotal = Convert.ToDecimal(TaxSummarylist[quoteitems.item_tax_rate_id]);
                                TaxSummarylist.Remove(quoteitems.item_tax_rate_id);
                                TaxSummarylist.Add(quoteitems.item_tax_rate_id, taxtotal + ((quoteitems.item_price * quoteitems.item_quantity) - quoteitems.item_discount_amount));
                            }

                        }
                    }
            

                    // taxContent
                    if (invoiceModel.quote_amount != null)
                    {
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> Sub Total </td> <td> " + invoiceModel.quote_amount.quote_item_subtotal.ToString() + "</td>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> Total Discount </td> <td> " + invoiceModel.quote_amount.quote_discount.ToString() + "</td>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> CGST </td> <td> " + invoiceModel.quote_amount.quote_tax_total / 2 + "</td>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> SGST </td> <td> " + invoiceModel.quote_amount.quote_tax_total / 2 + "</td>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> Total </td> <td> " + invoiceModel.quote_amount.quote_total.ToString() + "</td>";
                    }
                    else
                    {
                        taxContent = taxContent + "<tr  class=\"rtl\"> <td> Sub Total </td> <td> " + "1000.00" + "</td> </tr>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> Total Discount </td> <td> " + "10.00" + "</td> </tr>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> CGST </td> <td> " + "10.00" + "</td> </tr>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> SGST </td> <td> " + "10.00" + "</td> </tr>";
                        taxContent = taxContent + "<tr class=\"rtl\"> <td> Total </td> <td> " + "1010.00" + "</td> </tr>";
                    }

                    

            GridHtml = HTMLcontent;

            StringBuilder HTMLbuilder = new StringBuilder();
            HTMLbuilder.Append(HTMLContentBuilder().ToString());

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");
            //Company Details
            HTMLbuilder.Append("<td>");
            //Company Logo
            HTMLbuilder.Append("<img src=\"" + Server.MapPath("~/Content/") + "logo.jpg\" alt=\"Smiley face\" height=\"150\" width=\"150\"/>");
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("<td class=\"rtl\">");
            HTMLbuilder.Append("Company Name <br/>");
            HTMLbuilder.Append("Address line1 <br/>");
            HTMLbuilder.Append("Address line1 <br/>");
            HTMLbuilder.Append("City <br/>");
            HTMLbuilder.Append("</td>");

            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");
                        
            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");
            //Client Details
            HTMLbuilder.Append("<td>");
            HTMLbuilder.Append(GetClientDetails(Convert.ToInt32(ClientID)).ToString());
            HTMLbuilder.Append("</td>");
            // Invoice Details
            HTMLbuilder.Append("<td class=\"rtl\">");
            HTMLbuilder.Append("Invoice Number: " + invoiceModel.quote_number+ "<br/>");
            HTMLbuilder.Append("Date: " + invoiceModel.quote_date_created.ToString("dd/MM/yyyy") + "<br/>");
            HTMLbuilder.Append("");
            HTMLbuilder.Append("</td>");

            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append(tablecontent);
            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append(taxContent);
            HTMLbuilder.Append("</table>");

            if(invoiceModel.taxType!=null)
            {
                isIGST = false;
            }
            else
            {
                isIGST = true;
            }

            HTMLbuilder.Append(TaxSummary());
            
            HTMLbuilder.Append("</div>");
            HTMLbuilder.Append("</body>");
            HTMLbuilder.Append("</html>");

            GridHtml = HTMLbuilder.ToString();

            StringReader sr = new StringReader(GridHtml);

            System.IO.FileStream fs = new FileStream(Server.MapPath("~/PDFDownloads") + "\\" + id.ToString() + ".pdf", FileMode.Create);
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
            document.Close();
            writer.Close();
            fs.Close();


            //byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("../PDF/" + InvoiceNumber+ ".pdf"));
            string fullPath = Path.Combine(Server.MapPath("~/PDFDownloads"), id.ToString() + ".pdf");
            string fileName = id.ToString() + ".pdf";
            return File(fullPath, "application/pdf", fileName);
        }

        public StringBuilder HTMLContentBuilder()
        {
            StringBuilder HTMLContent = new StringBuilder();

            string text = System.IO.File.ReadAllText(Server.MapPath("~/Content/") + "InvoiceTemplate.html");
            
            HTMLContent.Append(text);
            
            return HTMLContent;
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

        public string HTMLTableHeader()
        {
            string tablecontent = string.Empty;

            tablecontent = tablecontent + "<tr class=\"heading\"> ";
            tablecontent = tablecontent + "<td>  Product Code</td>";
            tablecontent = tablecontent + "<td>  Product Name</td>";
            tablecontent = tablecontent + "<td>  Description</td>";
            tablecontent = tablecontent + "<td>  Quantity</td>";
            tablecontent = tablecontent + "<td>  Price</td>";
            tablecontent = tablecontent + "<td>  Discount</td>";
            tablecontent = tablecontent + "<td>  Tax</td>";
            tablecontent = tablecontent + "<td>  Total</td>";
            tablecontent = tablecontent + "</tr> ";

            return tablecontent;
        }

        public string TaxSummary()
        {
            string TaxSummaryContent = string.Empty;
            
            TaxSummaryContent = TaxSummaryContent + "<table> ";
            TaxSummaryContent = TaxSummaryContent + "<tr class=\"heading\"> ";
            TaxSummaryContent = TaxSummaryContent + "<td>  Tax Percentage</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  SubTotal</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  %</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  CGST</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  %</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  SGST</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  %</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  IGST</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  Tax Total</td>";
            TaxSummaryContent = TaxSummaryContent + "<td>  Total</td>";
            TaxSummaryContent = TaxSummaryContent + "</tr> ";

            if (TaxSummarylist == null)
            {
                TaxSummarylist = new Hashtable();
                TaxSummarylist.Add(18, 1200);
                TaxSummarylist.Add(24, 1500);
            }


            foreach (DictionaryEntry item in TaxSummarylist)
            {
                
                TaxSummaryContent = TaxSummaryContent + "<tr class=\"item\"> ";
                TaxSummaryContent = TaxSummaryContent + "<td> " + item.Key + " </td>";
                TaxSummaryContent = TaxSummaryContent + "<td> " + item.Value + " </td>";

                if (isIGST == false)
                {
                    TaxSummaryContent = TaxSummaryContent + "<td> " + Convert.ToInt32(item.Key)/2 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> " + (Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key) / 2)/100 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> " + Convert.ToInt32(item.Key)/ 2 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> " + (Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key) / 2) / 100 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> -- </td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> -- </td>";
                }
                else
                {
                    TaxSummaryContent = TaxSummaryContent + "<td>  --</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>  --</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>  --</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>  --</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>" + Convert.ToInt32(item.Key) +"</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>" + (Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100 + "</td>";
                }

                TaxSummaryContent = TaxSummaryContent + "<td>" +  (((Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100) ) + "</td>";
                TaxSummaryContent = TaxSummaryContent + "<td>" + (((Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100) + (Convert.ToInt32(item.Value))) + "</td>";
                TaxSummaryContent = TaxSummaryContent + "</tr> ";
            }



            TaxSummaryContent = TaxSummaryContent + "</table> ";
            return TaxSummaryContent;
        }

    }
}