using System;
using System.Collections.Generic;
using ContractorTimeChecker.DAL;
using ContractorTimeChecker.Models.Repository;

namespace ContractorTimeChecker.Repository
{
    public class CandidateRepository : IRepository<EntityBase>
    {
        private ApplicationContext context;

        public CandidateRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public EntityBase GetById(Int64 id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityBase> GetAll()
        {
            throw new NotImplementedException();
        }

        public RepositoryReponseBaseModel Create(EntityBase entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(EntityBase entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityBase entity)
        {
            throw new NotImplementedException();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}