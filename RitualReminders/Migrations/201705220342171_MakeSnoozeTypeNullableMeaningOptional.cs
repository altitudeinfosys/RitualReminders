namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeSnoozeTypeNullableMeaningOptional : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Todoes", "TodoSnoozeId", "dbo.TodoSnoozes");
            DropIndex("dbo.Todoes", new[] { "TodoSnoozeId" });
            AlterColumn("dbo.Todoes", "TodoSnoozeId", c => c.Byte());
            CreateIndex("dbo.Todoes", "TodoSnoozeId");
            AddForeignKey("dbo.Todoes", "TodoSnoozeId", "dbo.TodoSnoozes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Todoes", "TodoSnoozeId", "dbo.TodoSnoozes");
            DropIndex("dbo.Todoes", new[] { "TodoSnoozeId" });
            AlterColumn("dbo.Todoes", "TodoSnoozeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Todoes", "TodoSnoozeId");
            AddForeignKey("dbo.Todoes", "TodoSnoozeId", "dbo.TodoSnoozes", "Id", cascadeDelete: true);
        }
    }
}
