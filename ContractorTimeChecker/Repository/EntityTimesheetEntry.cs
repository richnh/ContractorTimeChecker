using System;

namespace ContractorTimeChecker.Repository
{
    public class EntityTimesheet : EntityBase
    {
        public string JobTitle { get; set; }

        public float Duration { get; set; }

        public string Date { get; set; } 
    }
}