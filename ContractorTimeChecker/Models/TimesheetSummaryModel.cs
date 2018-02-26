using System;
using ContractorTimeChecker.Models.Enums;

namespace ContractorTimeChecker.Models
{
    public class TimesheetSummaryModel
    {
        public int Id;

        public string CandidateName { get; set; }

        public string ClientName { get; set; }

        public string JobTitle { get; set; }

        public DateTime PlacementStartDate { get; set; }

        public DateTime PlacementEndDate{ get; set; }

        public PlacementTypeEnum PlacementType { get; set; }
    }
}