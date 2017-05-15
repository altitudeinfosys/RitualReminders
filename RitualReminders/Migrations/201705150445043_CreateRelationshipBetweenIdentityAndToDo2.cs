namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenIdentityAndToDo2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Todoes", "ApplicationUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Todoes", "ApplicationUserId", c => c.Int());
        }
    }
}
