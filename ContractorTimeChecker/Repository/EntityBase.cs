using System;

namespace ContractorTimeChecker.Repository
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }

        public string CandidateName { get; set; }

        public string ClientName { get; set; }
    }
}