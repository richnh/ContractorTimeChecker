using System;
using ContractorTimeChecker.Models.Enums;
using ContractorTimeChecker.Repository;

namespace ContractorTimeChecker.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TimeSheetEntryBase")]
    public class TimesheetSummary : EntityBase
    {
       // public DateTime PlacementEndDate {get; private set; }
    }
}