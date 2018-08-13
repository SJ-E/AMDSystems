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
    public class IPClientsController : Controller
    {
        IIPClients iPClientsRepository;
        IIPQuotes quoteService;
        IIPQuoteAmounts quoteAmountsService;
        IIPQuoteTaxRates quoteTaxRatesService;
        IIPQuoteItems quoteItemService;
        IIPUsers userService;
        IIPInvoices invoiceService;



        public IPClientsController()
        {
            iPClientsRepository = new IPClientsRepository();
            quoteService = new IPQuotesRepository();
            quoteAmountsService = new IPQuoteAmountsRepository();
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
            quoteItemService = new IPQuoteItemsRepository();
            userService = new IPUsersRepository();
            invoiceService = new IPInvoicesRepository();

        }
        // GET: IPClients

        public ActionResult DetailsAll()
        {
            var _allProducts = quoteService.FilterIPQuotes();
            return View(_allProducts);
        }

        [HttpPost]
        public ActionResult AddClient(IPClientsModel iPClientsModel)
        {
            iPClientsRepository.Add(iPClientsModel);
            return RedirectToAction("ViewAll");
        }

        public ActionResult AddClient()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Update(IPClientsModel iPClientsModel)
        {
            iPClientsRepository.Update(iPClientsModel);
            return RedirectToAction("ViewAll");
        }

        public ActionResult ViewAll(string keyword= "")
        {
            var _allClients =  iPClientsRepository.FilterIPClients(keyword);
            return View(_allClients);
        }

        public ActionResult ViewClient(int id)
        {
            var _ipClients = iPClientsRepository.FilterIPClients(id);
            return View(_ipClients);
        }

        public JsonResult GetAllClients()
        {
            var _allClients = iPClientsRepository.FilterIPClients();
            return Json(_allClients,JsonRequestBehavior.AllowGet) ;
            
        }

        public JsonResult GetAllSupplier()
        {
            var _allClients = iPClientsRepository.FilterIPSupplier(1);
            return Json(_allClients, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Edit(int Client_ID)
        {
            IPClientsModel iPClientsModel = iPClientsRepository.FilterIPClients(Client_ID);
            return View("Update", iPClientsModel);

        }

        public ActionResult Delete(int id)
        {
            iPClientsRepository.DeleteClient(id);
            return RedirectToAction("ViewAll");
        }

        public ActionResult Cancel()
        {
            return RedirectToAction("ViewAll");
        }
    }
}