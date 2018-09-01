using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetInfoController : Controller
    {
        private ApplicationContext context = new ApplicationContext();

        // GET: TimeSheetEntry
        public ActionResult Index()
        {
            List<TimesheetSummary> modelInfo = new List<TimesheetSummary>();

            return View(context.Timesheets.ToList());
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

        [HttpPost]
        public ActionResult Create(TimesheetSummary model)
        {
            try
            {
                context.Timesheets.Add(model);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
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
