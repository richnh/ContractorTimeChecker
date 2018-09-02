namespace ContractorTimeChecker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTimesheetEntryModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EntityTimesheets", "JobTitle", c => c.String());
            AddColumn("dbo.EntityTimesheets", "Duration", c => c.Single(nullable: false));
            AddColumn("dbo.EntityTimesheets", "Date", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EntityTimesheets", "Date");
            DropColumn("dbo.EntityTimesheets", "Duration");
            DropColumn("dbo.EntityTimesheets", "JobTitle");
        }
    }
}
