namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateRitualTodoFrequenciesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO RitualFrequencies  (RitualFrequencyId, Title, Hours) VALUES (1, 'Daily', 24)");
            Sql("INSERT INTO RitualFrequencies  (RitualFrequencyId, Title, Hours) VALUES (2, 'Hourly', 1)");
            Sql("INSERT INTO RitualFrequencies  (RitualFrequencyId, Title, Hours) VALUES (3, 'Weekly', 168)");

            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (1, 'Hourly', 1)");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (2, 'Daily', 24)");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (3, 'Weekly', 168)");
            
            



        }
        
        public override void Down()
        {
        }
    }
}
