using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Repository;

namespace AMDSystems.Controllers
{
    public class IPTaxRatesController : Controller
    {

        IIPTaxRates taxRatesService;
        public IPTaxRatesController()
        {
            taxRatesService = new IPTaxRatesRepository();
        }

        // GET: IPQuoteTaxRates
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddTaxrates()
        {

            return View(new IPTaxRatesModel());
        }

        [HttpPost]
        public ActionResult AddTaxrates(IPTaxRatesModel model)
        {
            taxRatesService.Add(model);
            return RedirectToAction("ViewTaxRates");
        }


        public ActionResult EditTaxrates(int id)
        {
            var taxRate = taxRatesService.FilterIPTaxRates(id);

            return View(taxRate);
        }

        [HttpPost]
        public ActionResult EditTaxrates(IPTaxRatesModel model)
        {
            taxRatesService.update(model);
            return RedirectToAction("ViewTaxRates");
        }


        public ActionResult ViewTaxRates()
        {
            var lstTaxRates = taxRatesService.FilterIPTaxRates();
            return View(lstTaxRates);
        }



        public ActionResult GetAllTaxRate()
        {
            return Json(taxRatesService.FilterIPTaxRates(), JsonRequestBehavior.AllowGet);
        }
    }
}