using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Repository;
using System;

namespace ContractorTimeChecker.Controllers
{
    [Authorize]
    public class TimeSheetSummaryController : Controller
    {
        private ApplicationContext context = new ApplicationContext();

        private IRepository repository;

        public TimeSheetSummaryController(IRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            TimesheetSummaryModel model = new TimesheetSummaryModel();

            model.CandidateNamesVM = new Models.ViewModels.CandidateNameViewModel()
            {
                //CandidateNames = repository.GetCandidateNames()
            };

            model.CandidateSummaryVM = new Models.ViewModels.TimesheetContractorSummaryVM()
            {
                //ContractorSummary = repository.GetCandidateSummary(string.Empty)
            };

            return View(model);
        }

        /// <summary>
        /// Creates a new summary object to be displayed using the model
        /// parameters parsed in
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        //[HttpPost]
        //public ActionResult Create(TimesheetSummaryModel model)
        //{
        //    try
        //    {
        //        model.CandidateNamesVM = new Models.ViewModels.CandidateNameViewModel()
        //        {
        //            //CandidateNames = repository.GetCandidateNames()
        //        };

        //        return View("Summary", repository.GetCandidateEmploymentSummary(model));
        //    }
        //    catch(Exception ex)
        //    {
        //        return View();
        //    }
        //}
    }
}
