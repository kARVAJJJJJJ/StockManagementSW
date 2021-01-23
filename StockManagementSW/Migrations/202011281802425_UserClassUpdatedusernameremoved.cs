namespace StockManagementSW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserClassUpdatedusernameremoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Username", c => c.String());
        }
    }
}
