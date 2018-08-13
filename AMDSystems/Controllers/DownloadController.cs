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
using System.Globalization;
using System.Net.Mail;
using System.Web.Configuration;

namespace AMDSystems.Controllers
{
    public class DownloadController : Controller
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

        public DownloadController() {

            quoteService = new IPQuotesRepository();

            quoteAmountsService = new IPQuoteAmountsRepository();
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
            quoteItemService = new IPQuoteItemsRepository();
            clientService = new IPClientsRepository();
            userService = new IPUsersRepository();
            paymentService = new IPPaymentsRepository();
            invoiceService = new IPInvoicesRepository();
        }

        public void SendEmail(int id)
        {
            var GridHtml = GetHtmlString(id);
            MailMessage mail = new MailMessage();
            mail.To.Add(WebConfigurationManager.AppSettings["ToMail"]);
            mail.From = new MailAddress(WebConfigurationManager.AppSettings["username"]);
            //mail.To.Add("jaitrustu@gmail.com");
            //mail.From = new MailAddress("jaiganesh.sve@gmail.com");
            mail.Subject = "Invoice";
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential
            (WebConfigurationManager.AppSettings["username"], WebConfigurationManager.AppSettings["password"]);// Enter seders User name and password

            
            smtp.EnableSsl = true;
            smtp.Send(mail);
            mail.Body = GridHtml;

        }
        
        [HttpGet]
        public FileResult DownloadPDF(int id)
        {
            var GridHtml =GetHtmlString(id);
            StringReader sr = new StringReader(GridHtml);
            MemoryStream ms = new MemoryStream();
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            PdfWriter writer = PdfWriter.GetInstance(document, ms);
            document.Open();
            XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
            document.Close();
            writer.Close();
            byte[] buffer = ms.ToArray();
            ms.Flush();
            string fileName = id.ToString() + DateTime.Now.ToString("ddmmyy") + ".pdf";
            return File(buffer, fileName);
        }
        private string GetHtmlString(int id)
        {
            string GridHtml, HTMLcontent = string.Empty, taxContent = string.Empty, tablecontent = string.Empty;
            var invoiceModel = quoteService.FilterAllType(id);
            var quoteModel = quoteService.FilterIPQuotes(id);
            var lsQuotesModel = quoteItemService.FilterIPQuoteItems(quoteModel).ToList();
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);
            quoteModel.quote_tax_rate = quoteTaxRatesService.FilterIPQuoteTaxRates(quoteModel);
            quoteModel.quote_amount = quoteAmountsService.FilterIPQuoteAmounts(quoteModel);
            quoteModel.client = clientService.FilterIPClients(quoteModel.client_id);
            quoteModel.user = userService.FilterIPUsers(quoteModel.user_id);


            int ClientID = invoiceModel.client_id;


            decimal taxtotal = 0;

            #region Quote Item
            tablecontent = tablecontent + HTMLTableHeader();

            //Products -- Quote Items
            //Products -- Quote Items
            if (lsQuotesModel.Count > 0)
            {
                TaxSummarylist = new Hashtable();
                //foreach (IPQuoteItemsModel quoteitems in lsQuotesModel)
                for (int i = 0; i < lsQuotesModel.Count; i++)
                {
                    var quoteitems = lsQuotesModel[i];
                    tablecontent = tablecontent + "<tr> ";
                    tablecontent = tablecontent + "<td> " + (i + 1).ToString() + "</td>";
                    tablecontent = tablecontent + "<td word-wrap:break-word> " + quoteitems.product.product_name + "</td>";
                    tablecontent = tablecontent + "<td> " + quoteitems.product.product_description + "</td>";
                    tablecontent = tablecontent + "<td> " + (quoteitems.item_quantity.HasValue ? quoteitems.item_quantity.Value.ToString("00") : string.Empty) + "</td>";
                    tablecontent = tablecontent + "<td> " + quoteitems.product.selling_price + "</td>";
                    tablecontent = tablecontent + "<td> " + (quoteitems.item_discount_amount.HasValue ? quoteitems.item_discount_amount.Value.ToString("00") : string.Empty) + "</td>";
                    tablecontent = tablecontent + "<td> " + quoteitems.product.tax_Model.tax_rate_percent.ToString("00") + "%</td>";
                    int sellingprice = 0;
                    int.TryParse(quoteitems.product.selling_price, out sellingprice);
                    var amtWithDiscount = (quoteitems.item_quantity.Value * sellingprice) - (quoteitems.item_discount_amount.HasValue ? quoteitems.item_discount_amount.Value : 0);
                    tablecontent = tablecontent + "<td>" + (amtWithDiscount + (amtWithDiscount * (quoteitems.product.tax_Model.tax_rate_percent / 100))).ToString("00") + "</td>";
                    tablecontent = tablecontent + "</tr>";

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

            #endregion

            #region  tax
            // taxContent
            if (invoiceModel.quote_amount != null)
            {
                taxContent = taxContent + "<tr class=\"rtl\"> <td> Sub Total </td> <td> " + invoiceModel.quote_amount.quote_item_subtotal.ToString() + "</td></tr>";
                taxContent = taxContent + "<tr class=\"rtl\"> <td> Total Discount </td> <td> " + invoiceModel.quote_amount.quote_discount.ToString() + "</td></tr>";
                taxContent = taxContent + "<tr class=\"rtl\"> <td> CGST </td> <td> " + invoiceModel.quote_amount.quote_tax_total / 2 + "</td></tr>";
                taxContent = taxContent + "<tr class=\"rtl\"> <td> SGST </td> <td> " + invoiceModel.quote_amount.quote_tax_total / 2 + "</td></tr>";
                taxContent = taxContent + "<tr class=\"rtl\"> <td> Total </td> <td> " + invoiceModel.quote_amount.quote_total.ToString() + "</td></tr>";
            }

            #endregion

            GridHtml = HTMLcontent;

            StringBuilder HTMLbuilder = new StringBuilder();
            HTMLbuilder.Append(HTMLContentBuilder().ToString());

            HTMLbuilder.Append("<table>");

            HTMLbuilder.Append("<tr>");
            #region address
            HTMLbuilder.Append("<td width=\"40%\">");
            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");

            {
                HTMLbuilder.Append("<td>");
                HTMLbuilder.Append("AMD Systems <br/>");
                HTMLbuilder.Append("1st First Floor Lakshmi theater complex<br/>");
                HTMLbuilder.Append("Anna Salai <br/>");
                HTMLbuilder.Append("Vellor 6320001<br/>");
                HTMLbuilder.Append("</td>");
            }
            //Logo
            {
                HTMLbuilder.Append("<td>");
                HTMLbuilder.Append("<img src=\"" + Server.MapPath("~/Content/") + "logo.jpg\" alt=\"Smiley face\" height=\"150\" width=\"150\"/>");
                HTMLbuilder.Append("</td>");
            }
            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");
            HTMLbuilder.Append("</td>");


            HTMLbuilder.Append("<td class=\"rtl\" width=\"60%\">");
            HTMLbuilder.Append("<table>");
            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td>");
            HTMLbuilder.Append(GetClientDetails(Convert.ToInt32(ClientID)).ToString());
            HTMLbuilder.Append("</td>");

            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");
            HTMLbuilder.Append("</td>");

            #endregion
            HTMLbuilder.Append("</tr>");


            HTMLbuilder.Append("<tr>");
            #region Quote Details
            HTMLbuilder.Append("<td>");
            HTMLbuilder.Append("<table  width=\"40%\">");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Quote No</td>");
            HTMLbuilder.Append("<td> " + quoteModel.quote_id.ToString());
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Quote Date</td>");
            HTMLbuilder.Append("<td> " + quoteModel.quote_date_created.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Delivery Notes</td>");
            HTMLbuilder.Append("<td> " + quoteModel.delivery_notes != null ? quoteModel.delivery_notes : string.Empty + "</td>");
            HTMLbuilder.Append("</tr>");
            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("</td>");


            HTMLbuilder.Append("<td >");

            HTMLbuilder.Append("<table width=\"60%\">");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Payment Method</td>");
            HTMLbuilder.Append("<td> CASH </td>");
            HTMLbuilder.Append("</tr>");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Amount Due</td>");
            HTMLbuilder.Append("<td> " + quoteModel.quote_amount.quote_total);
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td> Tax</td>");
            HTMLbuilder.Append("<td> " + quoteModel.quote_amount.quote_tax_total);
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");

            HTMLbuilder.Append("</table>");

            HTMLbuilder.Append("</td>");


            #endregion
            HTMLbuilder.Append("</tr>");



            #region  Final
            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td colspan=\"2\">");
            HTMLbuilder.Append("<table width=\"100%\" >");
            HTMLbuilder.Append(tablecontent);
            HTMLbuilder.Append("</table>");
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");



            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td  colspan=\"2\">");
            HTMLbuilder.Append("<table  width=\"100%\">");
            HTMLbuilder.Append(taxContent);
            HTMLbuilder.Append("</table>");
            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");


            if (invoiceModel.taxType != null)
            {
                isIGST = false;
            }
            else
            {
                isIGST = true;
            }

            HTMLbuilder.Append("<tr>");
            HTMLbuilder.Append("<td  colspan=\"2\">");

            //   HTMLbuilder.Append(TaxSummary());

            HTMLbuilder.Append("</td>");
            HTMLbuilder.Append("</tr>");

            #endregion



            HTMLbuilder.Append("</table>");


            HTMLbuilder.Append("</div>");
            HTMLbuilder.Append("</body>");
            HTMLbuilder.Append("</html>");


            GridHtml = HTMLbuilder.ToString();
            return GridHtml;
        }


        private object GetInvoiceDetails1(IPQuotesModel invoiceModel)
        {
            StringBuilder HTMLContent = new StringBuilder();

            //var client = clientService.FilterIPClients(clientID);

            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Invoice Number", invoiceModel.quote_number.ToString()));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Delivery Notes", "Delivery by Hand"));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Order by", " "));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Due Date", " "));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Amount Due", " "));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Payment Method", " "));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Tax Code", " "));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "VAT", " "));

            return HTMLContent;
        }

        private object GetInvoiceDetails2(IPQuotesModel invoiceModel)
        {
            StringBuilder HTMLContent = new StringBuilder();

            //var client = clientService.FilterIPClients(clientID);

            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Invoice Date", DateTime.Now.ToShortDateString()));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Delivery Date", DateTime.Now.ToShortDateString()));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Order Date", DateTime.Now.ToShortDateString()));
            HTMLContent.Append(string.Format("{0} \t{1}" + "<br/>", DateTime.Now.ToString(), ""));
            HTMLContent.Append(string.Format("{0} \t{1}" + "<br/>", "7500", ""));
            HTMLContent.Append(string.Format("{0} \t{1}" + "<br/>", "CHEQ", ""));
            HTMLContent.Append(string.Format("{0} \t{1}" + "<br/>", "33ANYPA2110Q1ZV", ""));
            HTMLContent.Append(string.Format("{0} \t{1}" + "<br/>", "ANYPA2110Q", ""));
            return HTMLContent;
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
            HTMLContent.Append(client.Client_Name.ToString() + "<br/>");

            if (client.Client_Address_1 != null)
            {
                HTMLContent.Append(client.Client_Address_1.ToString() + "<br/>");
            }
            if (client.Client_Address_2 != null)
            {
                HTMLContent.Append(client.Client_Address_2.ToString() + "<br/>");
            }
            if (client.Client_City != null)
            {
                HTMLContent.Append(client.Client_City.ToString() + "<br/>");
            }
            if (client.Client_Mobile != null)
            {
                HTMLContent.Append(client.Client_Mobile.ToString() + "<br/>");
            }
            return HTMLContent;
        }

        public StringBuilder GetBankDetails(int accId)
        {
            StringBuilder HTMLContent = new StringBuilder();

            //var client = clientService.FilterIPClients(clientID);

            HTMLContent.Append(string.Format("<p><b>{0}</b></p>" + "<br/>", "BANK DETAILS"));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Bank Name", "ANYPA2011Q"));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Account Number", "012414961878569"));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "IFSC Code", "HDFC0000124"));
            HTMLContent.Append(string.Format("{0} :\t{1}" + "<br/>", "Branch", "Vellore"));

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

            TaxSummaryContent = TaxSummaryContent + "<table border=\"1\"> ";
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
                    TaxSummaryContent = TaxSummaryContent + "<td> " + Convert.ToInt32(item.Key) / 2 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> " + (Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key) / 2) / 100 + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td> " + Convert.ToInt32(item.Key) / 2 + "</td>";
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
                    TaxSummaryContent = TaxSummaryContent + "<td>" + Convert.ToInt32(item.Key) + "</td>";
                    TaxSummaryContent = TaxSummaryContent + "<td>" + (Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100 + "</td>";
                }

                TaxSummaryContent = TaxSummaryContent + "<td>" + (((Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100)) + "</td>";
                TaxSummaryContent = TaxSummaryContent + "<td>" + (((Convert.ToInt32(item.Value) * Convert.ToInt32(item.Key)) / 100) + (Convert.ToInt32(item.Value))) + "</td>";
                TaxSummaryContent = TaxSummaryContent + "</tr> ";
            }



            TaxSummaryContent = TaxSummaryContent + "</table> ";
            return TaxSummaryContent;
        }
    }
}