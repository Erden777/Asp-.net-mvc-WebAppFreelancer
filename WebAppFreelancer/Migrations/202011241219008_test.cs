namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Services", "userID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Services", "userID", c => c.Int(nullable: false));
        }
    }
}
