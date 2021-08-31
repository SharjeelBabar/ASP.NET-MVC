namespace EidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eidi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fileimage = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        EndTime = c.String(),
                        CreatedAt = c.String(),
                        Descrpition = c.String(),
                        Image = c.String(),
                        MarchantId = c.Int(nullable: false),
                        ProductStatusId = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        Merchant_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Merchant_Id)
                .ForeignKey("dbo.ProductStatus", t => t.ProductStatusId)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId)
                .Index(t => t.ProductStatusId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.Merchant_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        DOB = c.String(),
                        JoinedOn = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Descrition = c.String(),
                        Icon = c.String(),
                        CategoreyId = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedAt = c.String(),
                        ShippingAddress = c.String(),
                        ClientId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        OrderStatusId = c.Int(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.ClientId)
                .ForeignKey("dbo.OrderStatus", t => t.OrderStatusId)
                .ForeignKey("dbo.Products", t => t.ProductId)
                .Index(t => t.ClientId)
                .Index(t => t.ProductId)
                .Index(t => t.OrderStatusId);
            
            CreateTable(
                "dbo.OrderStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "OrderStatusId", "dbo.OrderStatus");
            DropForeignKey("dbo.Orders", "ClientId", "dbo.Users");
            DropForeignKey("dbo.Images", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.Products", "ProductStatusId", "dbo.ProductStatus");
            DropForeignKey("dbo.Products", "Merchant_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropIndex("dbo.Orders", new[] { "OrderStatusId" });
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropIndex("dbo.Orders", new[] { "ClientId" });
            DropIndex("dbo.SubCategories", new[] { "Category_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Products", new[] { "Merchant_Id" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.Products", new[] { "ProductStatusId" });
            DropIndex("dbo.Images", new[] { "ProductId" });
            DropTable("dbo.OrderStatus");
            DropTable("dbo.Orders");
            DropTable("dbo.SubCategories");
            DropTable("dbo.ProductStatus");
            DropTable("dbo.Roles");
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Images");
            DropTable("dbo.Categories");
        }
    }
}
