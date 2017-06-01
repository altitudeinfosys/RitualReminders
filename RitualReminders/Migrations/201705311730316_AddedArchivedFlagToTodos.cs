namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedArchivedFlagToTodos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Archived", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Archived");
        }
    }
}
