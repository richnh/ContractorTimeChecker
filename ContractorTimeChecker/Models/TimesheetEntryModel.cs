using System;
using ContractorTimeChecker.Models.Enums;

namespace ContractorTimeChecker.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TimeSheetEntry")]
    public partial class TimeSheetEntryModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string CandidateName { get; set; }

        public string ClientName { get; set; }

        public string JobTitle { get; set; }

        public double? Duration { get; set; }

        public int? PlacementType { get; set; }
    }
}