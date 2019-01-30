namespace Proj.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSponsor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SponsorTeams",
                c => new
                    {
                        Sponsor_Id = c.Int(nullable: false),
                        Team_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sponsor_Id, t.Team_Id })
                .ForeignKey("dbo.Sponsors", t => t.Sponsor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.Team_Id, cascadeDelete: true)
                .Index(t => t.Sponsor_Id)
                .Index(t => t.Team_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SponsorTeams", "Team_Id", "dbo.Teams");
            DropForeignKey("dbo.SponsorTeams", "Sponsor_Id", "dbo.Sponsors");
            DropIndex("dbo.SponsorTeams", new[] { "Team_Id" });
            DropIndex("dbo.SponsorTeams", new[] { "Sponsor_Id" });
            DropTable("dbo.SponsorTeams");
            DropTable("dbo.Sponsors");
        }
    }
}
