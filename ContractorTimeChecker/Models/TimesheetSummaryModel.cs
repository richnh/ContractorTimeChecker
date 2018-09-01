using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.ViewModels;

namespace ContractorTimeChecker.Models
{
    public class TimesheetSummaryModel : EntityBase
    {
       
        public DateTime PlacementStartDate { get; set; }

        public DateTime PlacementEndDate{ get; set; }

        public CandidateNameViewModel CandidateNamesVM { get; set; }

        public TimesheetContractorSummaryVM CandidateSummaryVM { get; set; }

        public int CandidateNameIndex { get; set; }
    }
}