namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenIdentityAndToDo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "UserId", c => c.Int());
            AddColumn("dbo.Todoes", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Todoes", "ApplicationUser_Id");
            AddForeignKey("dbo.Todoes", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Todoes", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Todoes", "ApplicationUser_Id");
            DropColumn("dbo.Todoes", "UserId");
        }
    }
}
