﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;

namespace ContractorTimeChecker.Controllers
{
    public class TimeSheetEntryController : Controller
    {
        // GET: TimeSheetEntry
        public ActionResult Index()
        {
            return View();
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

        // POST: TimeSheetEntry/Create
        [HttpPost]
        public ActionResult Create(TimeSheetEntryModel model)
        {
            try
            {
                TimesheetContext context = new TimesheetContext();

                // TODO: Add insert logic here
                //TimeSheetEntryModel model = new TimeSheetEntryModel() { CandidateName = model.CandidateName, ClientName = model.ClientName };
                context.Timesheets.Add(model);

                context.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: TimeSheetEntry/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TimeSheetEntry/Edit/5
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
