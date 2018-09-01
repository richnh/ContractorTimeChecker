namespace ContractorTimeChecker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEntityTimesheetModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TimeSheetEntryBase", "Id", "dbo.EntityBases");
            DropIndex("dbo.TimeSheetEntryBase", new[] { "Id" });
            DropPrimaryKey("dbo.TimeSheetEntryBase");
            CreateTable(
                "dbo.EntityTimesheets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TimeSheetEntryBase", "CandidateName", c => c.String());
            AddColumn("dbo.TimeSheetEntryBase", "ClientName", c => c.String());
            AlterColumn("dbo.TimeSheetEntryBase", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TimeSheetEntryBase", "Id");
            DropTable("dbo.EntityBases");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.EntityBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        ClientName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropPrimaryKey("dbo.TimeSheetEntryBase");
            AlterColumn("dbo.TimeSheetEntryBase", "Id", c => c.Int(nullable: false));
            DropColumn("dbo.TimeSheetEntryBase", "ClientName");
            DropColumn("dbo.TimeSheetEntryBase", "CandidateName");
            DropTable("dbo.EntityTimesheets");
            AddPrimaryKey("dbo.TimeSheetEntryBase", "Id");
            CreateIndex("dbo.TimeSheetEntryBase", "Id");
            AddForeignKey("dbo.TimeSheetEntryBase", "Id", "dbo.EntityBases", "Id");
        }
    }
}
