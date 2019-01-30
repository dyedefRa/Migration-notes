namespace Proj.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePlayerAddress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PlayerAddresses",
                c => new
                    {
                        PlayerAdressID = c.Int(nullable: false),
                        City = c.String(),
                        Street = c.Int(nullable: false),
                        PostCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlayerAdressID)
                .ForeignKey("dbo.Players", t => t.PlayerAdressID)
                .Index(t => t.PlayerAdressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PlayerAddresses", "PlayerAdressID", "dbo.Players");
            DropIndex("dbo.PlayerAddresses", new[] { "PlayerAdressID" });
            DropTable("dbo.PlayerAddresses");
        }
    }
}
