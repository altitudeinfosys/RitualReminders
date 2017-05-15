namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeToProfileData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "MembershipTypeId", c => c.Byte());
            CreateIndex("dbo.AspNetUsers", "MembershipTypeId");
            AddForeignKey("dbo.AspNetUsers", "MembershipTypeId", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.AspNetUsers", new[] { "MembershipTypeId" });
            DropColumn("dbo.AspNetUsers", "MembershipTypeId");
        }
    }
}
