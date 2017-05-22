namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDetailToToDoModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Detail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Detail");
        }
    }
}
