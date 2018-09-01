namespace ContractorTimeChecker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityBaseRefactoring : DbMigration
    {
        public override void Up()
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

            DropTable("dbo.TimeSheetEntryBase");

            CreateTable(
                "dbo.TimeSheetEntryBase",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EntityBases", t => t.Id)
                .Index(t => t.Id);
            
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TimeSheetEntryBase",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateName = c.String(),
                        ClientName = c.String(),
                        JobTitle = c.String(),
                        Duration = c.Double(),
                        Date = c.DateTime(nullable: false),
                        PlacementType = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.TimeSheetEntryBase", "Id", "dbo.EntityBases");
            DropIndex("dbo.TimeSheetEntryBase", new[] { "Id" });
            DropTable("dbo.TimeSheetEntryBase");
            DropTable("dbo.EntityBases");
        }
    }
}
