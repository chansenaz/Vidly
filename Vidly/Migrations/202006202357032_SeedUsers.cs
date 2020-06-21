namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'25501f19-ad6e-44e6-9ead-f766d1640726', N'guest@vidly.com', 0, N'AOY6yHFWWL+95Jt0YEvIw5bDp4FInHOrfrHrLL6II9fH8qp5f1Pl4IvOwm+qo9FsSA==', N'191f6f97-9081-403a-901e-55251b456492', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'46942340-90da-4a36-9f8d-20283b99970c', N'admin@vidly.com', 0, N'AH7hgbdaf7+qYYz5HvQzjeDtgy6Coo8wmSXo/NN7kfDdCESQjgm2c9rGNB609Yil9w==', N'ab1ae868-26f3-490e-8954-b7c82b18347f', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')


                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a067ca8b-a6fe-48bf-a933-3e486ddd11cb', N'CanManageMovies')

                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'46942340-90da-4a36-9f8d-20283b99970c', N'a067ca8b-a6fe-48bf-a933-3e486ddd11cb')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
