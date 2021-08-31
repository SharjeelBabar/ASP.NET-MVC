namespace EidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class roles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseNo = c.String(),
                        StreetNo = c.String(),
                        Area = c.String(),
                        CityId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.CityId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddressDetails", "UserId", "dbo.Users");
            DropForeignKey("dbo.AddressDetails", "CityId", "dbo.Cities");
            DropIndex("dbo.AddressDetails", new[] { "UserId" });
            DropIndex("dbo.AddressDetails", new[] { "CityId" });
            DropTable("dbo.Cities");
            DropTable("dbo.AddressDetails");
        }
    }
}
