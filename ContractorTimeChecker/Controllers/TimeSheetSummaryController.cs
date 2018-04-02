using System;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using System.Collections.Generic;
using System.Linq;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetSummaryController : Controller
    {
        private TimesheetContext context = new TimesheetContext();

        public ActionResult Index()
        {
            TimesheetSummaryModel model = new TimesheetSummaryModel();

            model.CandidateNamesVM = new Models.ViewModels.CandidateNameViewModel()
            {
                CandidateNames = GetCandidateNames()
            };

            model.CandidateSummaryVM = new Models.ViewModels.TimesheetContractorSummaryVM()
            {
                ContractorSummary = GetCandidateSummary()
            };

            return View(model);
        }

        // GET: TimeSheet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(TimesheetSummaryModel model)
        {
            try
            {
                // TODO: Add insert logic here

                List<TimesheetEntryInfo> models = context.Timesheets.Where(x => x.Date >= model.PlacementStartDate).Where(x => x.Date <= model.PlacementEndDate).ToList();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

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

        IEnumerable<SelectListItem> GetCandidateNames()
        {
            IList<SelectListItem> list = new List<SelectListItem>();

            List<TimesheetEntryInfo> timesheetEntries = context.Timesheets.ToList();

            foreach(var entry in timesheetEntries)
            {
                list.Add( new SelectListItem() { Value = entry.Id.ToString(), Text = entry.CandidateName } );
            }

            return list;
        }

        IEnumerable<TimesheetEntryInfo> GetCandidateSummary()
        {
            IList<TimesheetEntryInfo> list = new List<TimesheetEntryInfo>();

            list = context.Timesheets.Where(x => x.CandidateName == "Richard Hale").ToList();

            return list;
        }
    }
}
