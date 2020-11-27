namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ResumeTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Contacts", "country_countryid", "dbo.Countries");
            DropForeignKey("dbo.Projects", "category_categoryid", "dbo.Categories");
            DropIndex("dbo.Contacts", new[] { "country_countryid" });
            DropIndex("dbo.Projects", new[] { "category_categoryid" });
            RenameColumn(table: "dbo.Contacts", name: "country_countryid", newName: "countryID");
            RenameColumn(table: "dbo.Projects", name: "category_categoryid", newName: "categoryID");
            CreateTable(
                "dbo.Resumes",
                c => new
                    {
                        resumeId = c.Int(nullable: false, identity: true),
                        knowledge = c.String(),
                        highSchoolName = c.String(),
                        experience = c.String(),
                        userID = c.Int(nullable: false),
                        user_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.resumeId)
                .ForeignKey("dbo.AspNetUsers", t => t.user_Id)
                .Index(t => t.user_Id);
            
            AlterColumn("dbo.Contacts", "countryID", c => c.Int(nullable: false));
            AlterColumn("dbo.Projects", "categoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Contacts", "countryID");
            CreateIndex("dbo.Projects", "categoryID");
            AddForeignKey("dbo.Contacts", "countryID", "dbo.Countries", "countryid", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "categoryID", "dbo.Categories", "categoryid", cascadeDelete: true);
            DropColumn("dbo.Projects", "category_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "category_id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Projects", "categoryID", "dbo.Categories");
            DropForeignKey("dbo.Contacts", "countryID", "dbo.Countries");
            DropForeignKey("dbo.Resumes", "user_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Resumes", new[] { "user_Id" });
            DropIndex("dbo.Projects", new[] { "categoryID" });
            DropIndex("dbo.Contacts", new[] { "countryID" });
            AlterColumn("dbo.Projects", "categoryID", c => c.Int());
            AlterColumn("dbo.Contacts", "countryID", c => c.Int());
            DropTable("dbo.Resumes");
            RenameColumn(table: "dbo.Projects", name: "categoryID", newName: "category_categoryid");
            RenameColumn(table: "dbo.Contacts", name: "countryID", newName: "country_countryid");
            CreateIndex("dbo.Projects", "category_categoryid");
            CreateIndex("dbo.Contacts", "country_countryid");
            AddForeignKey("dbo.Projects", "category_categoryid", "dbo.Categories", "categoryid");
            AddForeignKey("dbo.Contacts", "country_countryid", "dbo.Countries", "countryid");
        }
    }
}
