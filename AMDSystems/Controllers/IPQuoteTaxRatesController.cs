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
    public class IPQuoteTaxRatesController : Controller
    {

        IIPQuoteTaxRates quoteTaxRatesService;
        public IPQuoteTaxRatesController() {
            quoteTaxRatesService = new IPQuoteTaxRatesRepository();
        }

        // GET: IPQuoteTaxRates
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAllTaxRate(){
            return Json(quoteTaxRatesService.FilterIPQuoteTaxRates(),JsonRequestBehavior.AllowGet);
        }
    }
}