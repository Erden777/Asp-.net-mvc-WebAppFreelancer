namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjctsTable : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        projectid = c.Int(nullable: false, identity: true),
                        project_name = c.String(),
                        description = c.String(),
                        deadline = c.DateTime(nullable: false),
                        category_id = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        only_pro_programmers = c.Boolean(nullable: false),
                        category_categoryid = c.Int(),
                    })
                .PrimaryKey(t => t.projectid)
                .ForeignKey("dbo.Categories", t => t.category_categoryid)
                .Index(t => t.category_categoryid);
           
        }
        
        public override void Down()
        {
           
        }
    }
}
