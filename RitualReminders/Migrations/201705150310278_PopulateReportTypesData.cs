namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateReportTypesData : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO ReportTypes  (Id, Description) VALUES (1, 'Daily')");
            Sql("INSERT INTO ReportTypes  (Id, Description) VALUES (2, 'Weekly')");
            Sql("INSERT INTO ReportTypes  (Id, Description) VALUES (3, 'Monthly')");
        }
        
        public override void Down()
        {
        }
    }
}
