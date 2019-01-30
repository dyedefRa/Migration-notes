namespace Proj.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamCountryIliski : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Country_Id", c => c.Int());
            CreateIndex("dbo.Teams", "Country_Id");
            AddForeignKey("dbo.Teams", "Country_Id", "dbo.Countries", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Teams", new[] { "Country_Id" });
            DropColumn("dbo.Teams", "Country_Id");
        }
    }
}
