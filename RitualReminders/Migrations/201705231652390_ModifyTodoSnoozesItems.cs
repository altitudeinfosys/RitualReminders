namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyTodoSnoozesItems : DbMigration
    {
        public override void Up()
        {

            Sql("Delete from TodoSnoozes");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (1, '15 Minutes',0.25 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (2, '30 Minutes',0.5 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (3, '1 Hour',1 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (4, '2 Hour',2 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (5, '3 Hour',3 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (6, '1 Day',24 )");
            Sql("INSERT INTO TodoSnoozes  (Id, Title, Hours) VALUES (7, '2 Days',48 )");

        }
        
        public override void Down()
        {
        }
    }
}
