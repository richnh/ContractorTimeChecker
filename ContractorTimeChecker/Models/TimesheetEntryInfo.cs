using System;
using ContractorTimeChecker.Models.Enums;

namespace ContractorTimeChecker.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TimeSheetEntryBase")]   
    public partial class TimesheetEntryInfo : TimeSheetEntryModelBase
    {
        public int Id { get; set; }

        public string CandidateName { get; set; }

        public string ClientName { get; set; }

        public string JobTitle { get; set; }

        public double ? Duration { get; set; }

        public DateTime Date { get; set; }

        public int ? PlacementType { get; set; }
    }
}