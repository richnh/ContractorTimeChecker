using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.Repository;

namespace ContractorTimeChecker.Repository
{
    public interface IRepository : IDisposable
    {
        EntityTimesheet GetById(Int64 id);

        IEnumerable<EntityTimesheet> GetAll();

        RepositoryReponseBaseModel Create(EntityTimesheet entity);

        void Delete(EntityTimesheet entity);

        void Update(EntityTimesheet entity);
    }
}
