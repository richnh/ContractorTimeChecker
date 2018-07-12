using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContractorTimeChecker.Models;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Services;

namespace ContractorTimeChecker.Services
{
    public class TimeCheckerService : ITimeSheetSummaryService
    {
        private TimesheetContext context;

        public TimeCheckerService()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public TimeCheckerService(TimesheetContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<SelectListItem> GetCandidateNames()
        {
            var list = new List<SelectListItem>();

            foreach (var entry in context.Timesheets.ToList())
            {
                list.Add(new SelectListItem() { Value = entry.Id.ToString(), Text = entry.CandidateName });
            }

            return list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidateName"></param>
        /// <returns></returns>
        public IEnumerable<TimesheetEntryInfo> GetCandidateSummary(string candidateName)
        {
            var list = context.Timesheets.Where(x => x.CandidateName == candidateName).ToList();

            return list;
        }
    }
}