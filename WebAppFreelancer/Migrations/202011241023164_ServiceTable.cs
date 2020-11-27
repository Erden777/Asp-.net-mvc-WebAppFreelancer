namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServiceTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        serviceid = c.Int(nullable: false, identity: true),
                        serviceName = c.String(),
                        price = c.Int(nullable: false),
                        duration = c.String(),
                        level = c.String(),
                        userID = c.Int(nullable: false),
                        user_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.serviceid)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.user_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Services", "user_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Services", new[] { "user_Id" });
            DropTable("dbo.Services");
        }
    }
}
