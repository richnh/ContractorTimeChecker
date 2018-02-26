using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContractorTimeChecker.Models;

namespace ContractorTimeChecker.DAL
{
    public class TimesheetInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<TimesheetContext>
    {
        protected override void Seed(TimesheetContext context)
        {
            base.Seed(context);

            var timesheets = new List<TimeSheetEntryModel>();

            timesheets.Add(new TimeSheetEntryModel() { CandidateName = "Richard Hale", ClientName = "Adgistics", JobTitle = "C# Developer", Duration = 8.5 });

            timesheets.ForEach(t => context.Timesheets.Add(t));
            context.SaveChanges();
        }
    }
}