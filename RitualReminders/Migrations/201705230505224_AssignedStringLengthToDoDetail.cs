namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AssignedStringLengthToDoDetail : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Todoes", "Detail", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Todoes", "Detail", c => c.String());
        }
    }
}
