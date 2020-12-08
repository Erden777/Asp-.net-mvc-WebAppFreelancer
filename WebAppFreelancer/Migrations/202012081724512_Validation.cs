namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Projects", "project_name", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "description", c => c.String());
            AlterColumn("dbo.Projects", "project_name", c => c.String());
        }
    }
}
