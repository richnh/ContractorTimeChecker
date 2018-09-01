using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.ViewModels;

namespace ContractorTimeChecker.Models.ViewModels
{
    public class TimesheetContractorSummaryVM : EntityBase
    {
        public IEnumerable<TimesheetSummary> ContractorSummary { get; set; }
    }
}