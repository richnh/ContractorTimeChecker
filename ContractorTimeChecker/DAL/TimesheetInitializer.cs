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
            //base.Seed(context);

            //var timesheets = new List<TimesheetSummary>();

            //timesheets.Add(new TimesheetSummary() { CandidateName = "Richard Hale", ClientName = "Adgistics", JobTitle = "C# Developer", Duration = 8.5 });

            //timesheets.ForEach(t => context.Timesheets.Add(t));
            //context.SaveChanges();
        }
    }
}