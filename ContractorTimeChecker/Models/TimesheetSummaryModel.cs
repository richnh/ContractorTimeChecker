using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.ViewModels;

namespace ContractorTimeChecker.Models
{
    public class TimesheetSummaryModel : TimeSheetEntryModelBase
    {
        public IEnumerable<string> CandidateNames { get; set; }

        public IEnumerable<string> ClientNames { get; set; }

        public DateTime PlacementStartDate { get; set; }

        public DateTime PlacementEndDate{ get; set; }

        public CandidateNameViewModel CandidateNamesVM { get; set; }
    }
}