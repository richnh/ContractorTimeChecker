using System;
using ContractorTimeChecker.Models.Enums;
using System.Collections.Generic;
using System.Web.Mvc;
using ContractorTimeChecker.Models.ViewModels;

namespace ContractorTimeChecker.Models
{
    public class TimesheetSummaryModel
    {
        public int Id;

        public IEnumerable<string> CandidateName { get; set; }

        public List<string> ClientName { get; set; }

        public string JobTitle { get; set; }

        public DateTime PlacementStartDate { get; set; }

        public DateTime PlacementEndDate{ get; set; }

        public PlacementTypeEnum PlacementType { get; set; }

        public CandidateNameViewModel CandidateNamesVM { get; set; }
    }
}