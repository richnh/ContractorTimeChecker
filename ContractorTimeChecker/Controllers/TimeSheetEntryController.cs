using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Services;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetEntryController : Controller
    {
        private TimesheetContext context = new TimesheetContext();

        private ITimeSheetEntryService service;

        public TimeSheetEntryController(ITimeSheetEntryService service )
        {
            this.service = service;
        }

        // GET: TimeSheetEntry
        public ActionResult Index()
        {
            List<TimeSheetEntryModelBase> modelInfo = new List<TimeSheetEntryModelBase>();

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
        public ActionResult Create(TimesheetEntryInfo model)
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
