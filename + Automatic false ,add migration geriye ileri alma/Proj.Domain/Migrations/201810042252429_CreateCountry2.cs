namespace Proj.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCountry2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Countries");
        }
    }
}
