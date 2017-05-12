namespace RitualReminders.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'274a7ccd-14ff-48e0-a14b-da5f15b04536', N'admin@altitudeinfosys.com', 0, N'AN47XFAvid1Gb710LeTVetiw0vTGV/J6eZtjex2XADrZBsgm731Qy/2nK60vWTjFfw==', N'482bb38b-4705-4598-9d29-82112a889ca9', NULL, 0, 0, NULL, 1, 0, N'admin@altitudeinfosys.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'6c422416-794b-4a0d-b63c-53658282cd65', N'tareka@gmail.com', 0, N'AHqWBzugTsMlbOaHaqJ+IkN/Y083y1tglHoAaommQbqqMVZY1rISgbh5lYl9OyAC9w==', N'7bcf1340-516f-4ca5-9f33-0cc557522bcc', NULL, 0, 0, NULL, 1, 0, N'tareka@gmail.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c38a1694-3d12-4c74-9aa5-0818a86cc438', N'guest@altitudeinfosys.com', 0, N'ALkr1jhUoYo+DShF5sQrV0+Os92C9yt4IL87mbrcVIAnOJgAgbsRdIdU9F4hB8TJsg==', N'77d43542-4cbe-4ca4-9fa6-ee5aca2cb8af', NULL, 0, 0, NULL, 1, 0, N'guest@altitudeinfosys.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3dec29a0-f517-4855-9277-8c6cff0542d8', N'Admin')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'274a7ccd-14ff-48e0-a14b-da5f15b04536', N'3dec29a0-f517-4855-9277-8c6cff0542d8')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
