namespace EidAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dob : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "DOB");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "DOB", c => c.String());
        }
    }
}
