namespace Proj.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ONEMLI : DbMigration
    {
        public override void Up()
        {
            RenameColumn("Teams", "Ad", "Name");
            
        }
        
        public override void Down()
        {
            RenameColumn("Teams", "Name", "Ad");
        }
    }
}
