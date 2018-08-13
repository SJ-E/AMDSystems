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
    public class IPFamiliesController : Controller
    {
        IIPFamilies iPFamiliesRepository;

        public IPFamiliesController()
        {
            iPFamiliesRepository = new IPFamiliesRepository();
        }

        // GET: IPFamilies
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddFamily(IPFamiliesModel iPFamiliesModel)
        {
            iPFamiliesRepository.Add(iPFamiliesModel);
            return RedirectToAction("ViewAllFamily");
        }

        public ActionResult AddFamily()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UpdateFamily(IPFamiliesModel iPFamiliesModel)
        {
            iPFamiliesRepository.Update(iPFamiliesModel);
            return RedirectToAction("ViewAllFamily");
        }

        public ActionResult ViewAllFamily()
        {
            var _allFamilies = iPFamiliesRepository.FilterIPFamilies();
            return View(_allFamilies);
        }

        public ActionResult ViewFamily(int familyId)
        {
            IPFamiliesModel iPFamiliesModel = iPFamiliesRepository.FilterIPFamilies(familyId);
            return View(iPFamiliesModel);
        }

        public ActionResult Edit(int family_id)
        {
            IPFamiliesModel iPFamiliesModel = iPFamiliesRepository.FilterIPFamilies(family_id);
            return View("UpdateFamily", iPFamiliesModel);
        }

        public ActionResult Cancel()
        {
            return RedirectToAction("ViewAllFamily");
        }
    }
}