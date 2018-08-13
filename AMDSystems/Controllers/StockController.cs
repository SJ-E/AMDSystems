using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMDSystems.Controllers
{
    public class StockController : Controller
    {
        // GET: Reports
        public ActionResult Stock()
        {

            return View();
        }

       

        public ActionResult StockReport()
        {

            return View();
        }
    }
}