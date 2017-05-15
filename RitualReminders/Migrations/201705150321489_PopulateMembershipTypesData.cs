namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes  (Id, Description) VALUES (1, 'Free')");
            Sql("INSERT INTO MembershipTypes  (Id, Description) VALUES (2, 'Premium')");
            
        }
        
        public override void Down()
        {
        }
    }
}
