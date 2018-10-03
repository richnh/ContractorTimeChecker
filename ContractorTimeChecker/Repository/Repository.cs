using System;
using System.Collections.Generic;
using ContractorTimeChecker.DAL;
using System.Linq;
using ContractorTimeChecker.Models.Repository;
using System.Text;

namespace ContractorTimeChecker.Repository
{
    public class RepositoryTimesheetEntry : IRepository
    {
        private ApplicationContext context;

        public RepositoryTimesheetEntry(ApplicationContext context)
        {
            this.context = context;
        }

        public EntityTimesheet GetById(Int64 id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityTimesheet> GetAll()
        {
            return context.TimesheetEntries.ToList();
        }

        public RepositoryReponseBaseModel Create(EntityTimesheet entity)
        {
            bool state = false;

            StringBuilder sb = new StringBuilder();
            
            try
            {
                context.TimesheetEntries.Add(entity);
                context.SaveChanges();

                state = true;

                sb.Append("Created Successfully");
            }
            catch(Exception ex)
            {
                state = false;

                sb.Append(ex.Message);
            }

            return new RepositoryReponseBaseModel(state, sb.ToString());
        }

        public void Delete(EntityTimesheet entity)
        {
            throw new NotImplementedException();
        }

        public void Update(EntityTimesheet entity)
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