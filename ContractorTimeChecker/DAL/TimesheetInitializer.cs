using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContractorTimeChecker.Models;

namespace ContractorTimeChecker.DAL
{
    public class TimesheetInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            
        }
    }
}