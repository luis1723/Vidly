namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'04b3306c-0cb2-480a-b266-89e36fa45331', N'admin@vidly.com', 0, N'AChCY1hfskbEVvUHBUbGIIP8lyMuHOgqvHCMW9EVk4Z6reniCt6IAi1pYk9ifuoToQ==', N'7cb3d09d-8886-4076-9d25-c8b5d0664e02', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dc3af029-77c4-4189-8cdf-5160a7aea0d1', N'guestuser@vidly.com', 0, N'ADSVfXavLuT8KH/7cU9MZPyCKJBPEx5uHuZ/Inog6A6TYeotU0wYYEBy5wkZr8EuUg==', N'74d987f0-01a9-4d89-a0c0-bd8fbab49478', NULL, 0, 0, NULL, 1, 0, N'guestuser@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'ba1b0378-738c-47a0-acda-9b5374b77032', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'04b3306c-0cb2-480a-b266-89e36fa45331', N'ba1b0378-738c-47a0-acda-9b5374b77032')

");
        }
        
        public override void Down()
        {
        }
    }
}
