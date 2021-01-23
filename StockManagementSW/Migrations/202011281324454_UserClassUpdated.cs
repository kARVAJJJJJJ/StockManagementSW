namespace StockManagementSW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserClassUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Fullname", c => c.String());
            AddColumn("dbo.Users", "HashedUsername", c => c.String());
            AddColumn("dbo.Users", "Isactive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Users", "Isadmin", c => c.Boolean(nullable: false));
            DropColumn("dbo.Users", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Type", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Isadmin");
            DropColumn("dbo.Users", "Isactive");
            DropColumn("dbo.Users", "HashedUsername");
            DropColumn("dbo.Users", "Fullname");
        }
    }
}
