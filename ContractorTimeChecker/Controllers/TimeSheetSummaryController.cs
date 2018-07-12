using System;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using System.Collections.Generic;
using System.Linq;
using ContractorTimeChecker.Services;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetSummaryController : Controller
    {
        private TimesheetContext context = new TimesheetContext();

        ITimeSheetSummaryService service;

        public TimeSheetSummaryController()
        {
            service = new TimeCheckerService();
        }

        public TimeSheetSummaryController(ITimeSheetSummaryService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            TimesheetSummaryModel model = new TimesheetSummaryModel();

            TimeCheckerService service = new TimeCheckerService(context);

            model.CandidateNamesVM = new Models.ViewModels.CandidateNameViewModel()
            {
                CandidateNames = service.GetCandidateNames()
            };

            model.CandidateSummaryVM = new Models.ViewModels.TimesheetContractorSummaryVM()
            {
                ContractorSummary = service.GetCandidateSummary(string.Empty)
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(TimesheetSummaryModel model)
        {
            try
            {
                // TODO: Add insert logic here

                List<TimesheetEntryInfo> models = context.Timesheets.Where(x => x.Date >= model.PlacementStartDate).Where(x => x.Date <= model.PlacementEndDate).ToList();

                //List<TimesheetSummaryModel> summaryModels = new List<TimesheetSummaryModel>();

               

                return View("Summary", models);
            }
            catch
            {
                return View();
            }
        }
    }
}
