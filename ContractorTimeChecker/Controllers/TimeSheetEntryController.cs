using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Repository;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetEntryController : Controller
    {
        private IRepository<EntityTimesheet> repository;

        public TimeSheetEntryController(IRepository<EntityTimesheet> repository )
        {
            this.repository = repository;
        }

        // GET: TimeSheetEntry
        public ActionResult Index()
        {
            List<EntityBase> modelInfo = new List<EntityBase>();

            return View(repository.GetAll().ToList());
        }

        // GET: TimeSheetEntry/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TimeSheetEntry/Create
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult Create(EntityTimesheet model)
        {
            var response = repository.Create(model);

            return Json(response, JsonRequestBehavior.AllowGet);     
        }

        [HttpPut]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TimeSheetEntry/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeSheetEntry/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
