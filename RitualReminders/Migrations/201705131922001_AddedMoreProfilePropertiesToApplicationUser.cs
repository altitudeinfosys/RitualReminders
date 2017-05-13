namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreProfilePropertiesToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.AspNetUsers", "DateOfBirth", c => c.DateTime());
            AddColumn("dbo.AspNetUsers", "ReceiveNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ReceiveInspirationalReminders", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ReceiveTextMessagesReminders", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ReceiveEmailReminders", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ReceiveEmailReminders");
            DropColumn("dbo.AspNetUsers", "ReceiveTextMessagesReminders");
            DropColumn("dbo.AspNetUsers", "ReceiveInspirationalReminders");
            DropColumn("dbo.AspNetUsers", "ReceiveNewsletter");
            DropColumn("dbo.AspNetUsers", "DateOfBirth");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
