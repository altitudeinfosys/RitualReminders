namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MadeDueDateRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "DueDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "DueDate", c => c.DateTime());
        }
    }
}
