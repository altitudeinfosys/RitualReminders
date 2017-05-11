namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedToDoAndToDoSnooze : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Todoes",
                c => new
                    {
                        ToDoId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Completed = c.Boolean(nullable: false),
                        DueDate = c.DateTime(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                        TodoSnoozeId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoId)
                .ForeignKey("dbo.TodoSnoozes", t => t.TodoSnoozeId, cascadeDelete: true)
                .Index(t => t.TodoSnoozeId);
            
            CreateTable(
                "dbo.TodoSnoozes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Title = c.String(),
                        Hours = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "TodoSnoozeId", "dbo.TodoSnoozes");
            DropIndex("dbo.Todoes", new[] { "TodoSnoozeId" });
            DropTable("dbo.TodoSnoozes");
            DropTable("dbo.Todoes");
        }
    }
}
