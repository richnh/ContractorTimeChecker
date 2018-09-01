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
    public class TimeCheckerService : ITimeCheckerService
    {
        private ApplicationContext context;

        public TimeCheckerService()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public TimeCheckerService(ApplicationContext context)
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
    }
}