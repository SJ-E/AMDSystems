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
    public class IPSuppliersController : Controller
    {

        public IPSuppliersController()
        {
            iPClientsRepository = new IPClientsRepository();
        }
        

      
        public ActionResult ViewSupplier()
        {

            return View();
        }

         IIPClients iPClientsRepository;

        
        
        [HttpPost]
        public ActionResult AddSupplier(IPClientsModel iPClientsModel)
        {
            iPClientsRepository.Add(iPClientsModel);
            return RedirectToAction("ViewAll");
        }

        public ActionResult AddSupplier()
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
            var _allClients =  iPClientsRepository.FilterIPClients(keyword,1);
            return View(_allClients);
        }

        public ActionResult Update(int id)
        {
            var _ipClients = iPClientsRepository.FilterIPClients(id,1);
            return View(_ipClients);
        }

        public JsonResult GetAllViewSupplier()
        {
            var _allClients = iPClientsRepository.FilterIPSupplier(1);
            return Json(_allClients,JsonRequestBehavior.AllowGet) ;
            
        }
        public ActionResult Edit(int Supplier_ID)
        {
            IPClientsModel iPClientsModel = iPClientsRepository.FilterIPClients(Supplier_ID,1);
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