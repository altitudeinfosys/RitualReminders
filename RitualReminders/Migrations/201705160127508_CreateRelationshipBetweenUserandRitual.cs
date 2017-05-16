namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenUserandRitual : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rituals", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Rituals", "ApplicationUser_Id");
            AddForeignKey("dbo.Rituals", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rituals", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Rituals", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.Rituals", "ApplicationUser_Id");
        }
    }
}
