using System;

namespace ContractorTimeChecker.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class EntityBase
    {
        public int Id { get; protected set; }

        public string CandidateName { get; set; }

        public string ClientName { get; set; }

        public string JobTitle { get; set; }

        public double? Duration { get; set; }

        public DateTime Date { get; set; }

        public int? PlacementType { get; set; }
    }
}