namespace ContractorTimeChecker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUnusedProperties : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TimeSheetEntryBase", "CandidateNameIndex");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TimeSheetEntryBase", "CandidateNameIndex", c => c.Int(nullable: false));
        }
    }
}
