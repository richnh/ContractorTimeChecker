using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorTimeChecker.Repository
{
    public interface IRepository : IDisposable
    {
        EntityTimesheet GetById(Int64 id);

        IEnumerable<EntityTimesheet> GetAll();

        void Create(EntityTimesheet entity);

        void Delete(EntityTimesheet entity);

        void Update(EntityTimesheet entity);
    }
}
