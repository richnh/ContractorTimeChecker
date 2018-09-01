using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using System;
using System.Text;

namespace ContractorTimeChecker.Services
{
    public class TimeSheetSummaryService : ITimeCheckerService
    {
        private ApplicationContext context;

        public ApplicationContext Context { get; set; }

        public TimeSheetSummaryService(ApplicationContext context)
        {
            this.Context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetCandidateNames()
        {
            var list = new List<SelectListItem>();

            foreach (var entry in Context.Timesheets.ToList())
            {
                list.Add(new SelectListItem() { Value = entry.Id.ToString(), Text = entry.CandidateName });
            }

            return list;
        }

        //public List<TimesheetSummary> GetContractorEmploymentSummary(TimesheetSummaryModel model)
        //{
        //    var queryPlacementStartDate = false;
        //    var queryJobTitle = false;

        //    var contractorSummary = new List<TimesheetSummary>();
            
        //    var candidateName = model.CandidateNamesVM.CandidateNames.ElementAt(model.CandidateNameIndex-1);

        //    if(string.IsNullOrEmpty(candidateName.Text) )
        //    {
        //        throw new Exception("Invalid Candidate Name");
        //    }

        //    if (model.PlacementStartDate != null)
        //    {
        //        queryPlacementStartDate = true;
        //    }

        //    if(model.PlacementEndDate != null)
        //    {
        //        queryJobTitle = true;
        //    }

        //    if(queryPlacementStartDate  && queryJobTitle)
        //    {
        //        contractorSummary = Context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.Date > model.PlacementStartDate).Where(x => x.JobTitle == model.JobTitle).ToList();
        //    }
        //    else
        //    {
        //        if(queryPlacementStartDate)
        //        {
        //            contractorSummary = Context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.Date > model.PlacementStartDate).ToList();
        //        }
        //        else
        //        {
        //            contractorSummary = Context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.JobTitle == model.JobTitle).ToList();
        //        }  
        //    }
   
        //    return contractorSummary;
        //}


        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateName"></param>
        /// <returns></returns>
        public IEnumerable<TimesheetSummary> GetCandidateSummary(string candidateName)
        {
            var list = Context.Timesheets.Where(x => x.CandidateName == candidateName).ToList();

            return list;
        }
    }
}