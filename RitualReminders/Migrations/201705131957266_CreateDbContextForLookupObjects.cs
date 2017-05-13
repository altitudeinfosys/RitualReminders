namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDbContextForLookupObjects : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inspirations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(nullable: false),
                        ValidFrom = c.Byte(),
                        ValidTo = c.Byte(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InspirationTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ReportTypes",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ReportTypes");
            DropTable("dbo.MembershipTypes");
            DropTable("dbo.InspirationTypes");
            DropTable("dbo.Inspirations");
        }
    }
}
