namespace LWDC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserCategoryClubNameAndDesignation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserCategory", c => c.String());
            AddColumn("dbo.AspNetUsers", "Designation", c => c.String());
            AddColumn("dbo.AspNetUsers", "ClubName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ClubName");
            DropColumn("dbo.AspNetUsers", "Designation");
            DropColumn("dbo.AspNetUsers", "UserCategory");
        }
    }
}
