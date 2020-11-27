namespace WebAppFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Services", name: "user_Id", newName: "userID");
            RenameIndex(table: "dbo.Services", name: "IX_user_Id", newName: "IX_userID");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Services", name: "IX_userID", newName: "IX_user_Id");
            RenameColumn(table: "dbo.Services", name: "userID", newName: "user_Id");
        }
    }
}
