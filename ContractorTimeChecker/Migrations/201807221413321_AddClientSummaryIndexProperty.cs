namespace ContractorTimeChecker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientSummaryIndexProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TimeSheetEntryBase", "CandidateNameIndex", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TimeSheetEntryBase", "CandidateNameIndex");
        }
    }
}
