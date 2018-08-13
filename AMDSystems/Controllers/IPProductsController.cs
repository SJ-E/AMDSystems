using Core_Project.Model;
using Core_Project.Service;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AMDSystems.Controllers
{
    public class IPProductsController : Controller
    {
        IIPProducts ipProductsRepository;
        IIPFamilies iPFamiliesRepository;

        public IPProductsController()
        {
            ipProductsRepository = new IPProductsRepository();
            iPFamiliesRepository = new IPFamiliesRepository();
        }
        // GET: IPProducts`
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProducts(IPProductsModel iPProductsModel)
        {
            var result  = ipProductsRepository.Add(iPProductsModel);
            if (!result)
            {
                AddProductModel addProductModel = new AddProductModel();
                addProductModel.iPFamiliesModels = new List<IPFamiliesModel>();
                addProductModel.iPProductsModel = iPProductsModel;
                addProductModel.iPFamiliesModels = iPFamiliesRepository.FilterIPFamilies().ToList();
                ModelState.AddModelError("iPProductsModel.serial_number", "Serial Number should be unique");
                return View(addProductModel);

            }

            return RedirectToAction("ViewAll");
        }

        public ActionResult AddProducts()
        {
            AddProductModel addProductModel = new AddProductModel();
            addProductModel.iPFamiliesModels = new List<IPFamiliesModel>();
            addProductModel.iPProductsModel = new IPProductsModel();
            addProductModel.iPFamiliesModels = iPFamiliesRepository.FilterIPFamilies().ToList();
            return View(addProductModel);
        }

        [HttpPost]
        public ActionResult Update(IPProductsModel iPProductsModel)
        {
            ipProductsRepository.Update(iPProductsModel);
            return RedirectToAction("ViewAll");
        }

        public ActionResult ViewAll()
        {
            var _allProducts = ipProductsRepository.FilterIPProducts();
            return View(_allProducts);
        }

        public ActionResult ViewProduct(int id)
        {
            var _ipProducts = ipProductsRepository.FilterIPProducts(id);
            return View(_ipProducts);
        }

        public ActionResult Edit(int product_id)
        {
            AddProductModel addProductModel = new AddProductModel();
            addProductModel.iPFamiliesModels = new List<IPFamiliesModel>();
            addProductModel.iPProductsModel = ipProductsRepository.FilterIPProducts(product_id);
            addProductModel.iPFamiliesModels = iPFamiliesRepository.FilterIPFamilies().ToList();
            return View("Update", addProductModel);
        }

        public ActionResult Delete(int id)
        {
            ipProductsRepository.Delete(id);
            return RedirectToAction("ViewAll");
        }

        public ActionResult FilterProduct(string keyword, int page)
        {
            var _allProducts = ipProductsRepository.FilterIPProducts(keyword,page);
            return Json(_allProducts, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Cancel()
        {
            return RedirectToAction("ViewAll");
        }

    }
}