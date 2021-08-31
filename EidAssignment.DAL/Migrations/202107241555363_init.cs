namespace EidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Products", new[] { "Merchant_Id" });
            RenameColumn(table: "dbo.Products", name: "Merchant_Id", newName: "MerchantId");
            AlterColumn("dbo.Products", "MerchantId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "MerchantId");
            DropColumn("dbo.Products", "MarchantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "MarchantId", c => c.Int(nullable: false));
            DropIndex("dbo.Products", new[] { "MerchantId" });
            AlterColumn("dbo.Products", "MerchantId", c => c.Int());
            RenameColumn(table: "dbo.Products", name: "MerchantId", newName: "Merchant_Id");
            CreateIndex("dbo.Products", "Merchant_Id");
        }
    }
}
