namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenIdentityAndToDo1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "ApplicationUserId", c => c.Int());
            DropColumn("dbo.Todoes", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "UserId", c => c.Int());
            DropColumn("dbo.Todoes", "ApplicationUserId");
        }
    }
}
