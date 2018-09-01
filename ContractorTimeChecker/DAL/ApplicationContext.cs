using ContractorTimeChecker.Models;
using System.Data.Entity;
using ContractorTimeChecker.Repository;

namespace ContractorTimeChecker.DAL
{
    public class ApplicationContext : DbContext
    {
        public DbSet<TimesheetSummary> Timesheets { get; set; }

        public DbSet<EntityTimesheet> TimesheetEntries { get; set; }

        public ApplicationContext() : base("TimesheetContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}