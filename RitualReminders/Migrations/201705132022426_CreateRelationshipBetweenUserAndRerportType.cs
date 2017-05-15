namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateRelationshipBetweenUserAndRerportType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ReportTypeId", c => c.Byte());
            CreateIndex("dbo.AspNetUsers", "ReportTypeId");
            AddForeignKey("dbo.AspNetUsers", "ReportTypeId", "dbo.ReportTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "ReportTypeId", "dbo.ReportTypes");
            DropIndex("dbo.AspNetUsers", new[] { "ReportTypeId" });
            DropColumn("dbo.AspNetUsers", "ReportTypeId");
        }
    }
}
