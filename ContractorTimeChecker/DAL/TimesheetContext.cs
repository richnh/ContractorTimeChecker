using ContractorTimeChecker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContractorTimeChecker.DAL
{
    public class TimesheetContext : DbContext
    {
        public DbSet<TimeSheetEntryModelBase> Timesheets { get; set; }

        public TimesheetContext() : base("TimesheetContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}