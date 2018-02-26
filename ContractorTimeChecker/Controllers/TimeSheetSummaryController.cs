using System;
using System.Web.Mvc;
using ContractorTimeChecker.Models;

namespace ContractorTimeChecker.Controllers
{
    public class TimeSheetSummaryController : Controller
    {
        // GET: TimeSheet
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TimeSheetEntryModel model)
        {
            return View();
        }

        // GET: TimeSheet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

               

        // POST: TimeSheet/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: TimeSheet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeSheet/Edit/5
        [HttpPost]
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

        // GET: TimeSheet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TimeSheet/Delete/5
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
