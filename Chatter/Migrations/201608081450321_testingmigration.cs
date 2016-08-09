namespace Chatter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testingmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Post", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Post");
        }
    }
}
