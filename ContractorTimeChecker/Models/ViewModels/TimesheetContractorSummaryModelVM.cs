using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.ViewModels;

namespace ContractorTimeChecker.Models.ViewModels
{
    public class TimesheetContractorSummaryVM : TimeSheetEntryModelBase
    {
        public IEnumerable<TimesheetEntryInfo> ContractorSummary { get; set; }
    }
}