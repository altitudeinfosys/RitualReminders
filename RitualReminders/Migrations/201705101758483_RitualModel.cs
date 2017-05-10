namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RitualModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Rituals",
                c => new
                    {
                        RitualId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 255),
                        Completed = c.Boolean(nullable: false),
                        DueDate = c.DateTime(),
                        CreateUser = c.String(),
                        CreateDate = c.DateTime(),
                        UpdateUser = c.String(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.RitualId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Rituals");
        }
    }
}
