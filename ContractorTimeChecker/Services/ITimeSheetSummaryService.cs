using System.Collections.Generic;
using System.Web.Mvc;

namespace ContractorTimeChecker.Services
{
    public interface ITimeCheckerService
    {
        IEnumerable<SelectListItem> GetCandidateNames();
    }
}