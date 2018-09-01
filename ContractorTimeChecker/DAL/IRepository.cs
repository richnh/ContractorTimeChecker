using System;
using System.Collections.Generic;
using System.Web.Mvc;
using ContractorTimeChecker.Models;

namespace ContractorTimeChecker.DAL
{
    public interface IRepository : IDisposable
    {
        IEnumerable<SelectListItem> GetCandidateNames();

        IEnumerable<TimesheetSummary> GetCandidateSummary(string candidateName);

        List<TimesheetSummary> GetCandidateEmploymentSummary(TimesheetSummaryModel model);
    }
}