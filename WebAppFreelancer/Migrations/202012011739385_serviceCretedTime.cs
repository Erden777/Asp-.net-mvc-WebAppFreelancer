namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class serviceCretedTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "createdDate", c => c.DateTime(nullable: false));    
        }
        
        public override void Down()
        {
            
        }
    }
}
