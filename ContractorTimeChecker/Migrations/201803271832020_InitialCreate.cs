namespace ContractorTimeChecker.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeSheetEntryBase");
        }
    }
}
