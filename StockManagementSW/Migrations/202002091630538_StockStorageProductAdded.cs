namespace StockManagementSW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StockStorageProductAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Category = c.String(),
                        PurchasePrice = c.Int(nullable: false),
                        SellingPrice = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Storage_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Storages", t => t.Storage_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Storage_Id);
            
            CreateTable(
                "dbo.Storages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stocks", "Storage_Id", "dbo.Storages");
            DropForeignKey("dbo.Stocks", "Product_Id", "dbo.Products");
            DropIndex("dbo.Stocks", new[] { "Storage_Id" });
            DropIndex("dbo.Stocks", new[] { "Product_Id" });
            DropTable("dbo.Storages");
            DropTable("dbo.Stocks");
            DropTable("dbo.Products");
        }
    }
}
