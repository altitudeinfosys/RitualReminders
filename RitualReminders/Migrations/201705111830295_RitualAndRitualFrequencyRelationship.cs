namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RitualAndRitualFrequencyRelationship : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RitualFrequencies",
                c => new
                    {
                        RitualFrequencyId = c.Byte(nullable: false),
                        Title = c.String(nullable: false, maxLength: 255),
                        Hours = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.RitualFrequencyId);
            
            AddColumn("dbo.Rituals", "RitualFrequencyId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Rituals", "RitualFrequencyId");
            AddForeignKey("dbo.Rituals", "RitualFrequencyId", "dbo.RitualFrequencies", "RitualFrequencyId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rituals", "RitualFrequencyId", "dbo.RitualFrequencies");
            DropIndex("dbo.Rituals", new[] { "RitualFrequencyId" });
            DropColumn("dbo.Rituals", "RitualFrequencyId");
            DropTable("dbo.RitualFrequencies");
        }
    }
}
