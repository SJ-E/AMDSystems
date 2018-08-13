using Core_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMDSystems.Controllers
{
    public class IPPaymentsController : Controller
    {
        // GET: IPPayments
        public ActionResult EnterPayment()
        {
            return View();
        }

        public ActionResult ViewPayments()
        {
            return View();
        }

        public ActionResult AddPaymentMethod()
        {
            return View();
        }

        
    }
}