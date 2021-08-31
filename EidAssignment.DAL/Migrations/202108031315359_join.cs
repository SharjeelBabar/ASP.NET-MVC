namespace EidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class join : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PhoneNo", c => c.String());
            AlterColumn("dbo.Users", "JoinedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "JoinedOn", c => c.String());
            DropColumn("dbo.Users", "PhoneNo");
        }
    }
}
