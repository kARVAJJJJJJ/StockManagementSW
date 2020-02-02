namespace StockManagementSW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        HashedPassword = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            // D:\Torrent\Udemy - Entity Framework in Depth\08 Updating Data
        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
