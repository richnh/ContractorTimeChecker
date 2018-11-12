using System;
using System.Collections.Generic;
using ContractorTimeChecker.Models.Repository;

namespace ContractorTimeChecker.Repository
{
    public interface IRepository<T> : IDisposable
    {
        T GetById(Int64 id);

        IEnumerable<T> GetAll();

        RepositoryReponseBaseModel Create(T entity);

        void Delete(T entity);

        void Update(T entity);
    }
}
