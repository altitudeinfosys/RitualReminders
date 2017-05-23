namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingHoursInTodoSnoozesToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TodoSnoozes", "Hours", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TodoSnoozes", "Hours", c => c.Byte(nullable: false));
        }
    }
}
