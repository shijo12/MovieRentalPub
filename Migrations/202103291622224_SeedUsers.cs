namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'83bdb197-1ed9-4594-89d9-68cc99e0d603', N'Admin@Vidly.com', 0, N'AOImvooxUiFDmN/0DEws0H8gZVuN9QVoa3ByCVr7aqyQaxsvoocgM9WKAZvA+y2nVw==', N'2eb6e504-0e57-441f-b4f1-ba90438ad4a1', NULL, 0, 0, NULL, 1, 0, N'Admin@Vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f68458ab-d8d6-4d93-8f8d-05b082b4d807', N'Guest@Vidly.com', 0, N'AMl6F18m9eq/Pz3sdoXgOzyX65sGOiYGu1lmKqxDnVmN4Ddt5fU15w8wk//KvrvFxg==', N'6a0ade25-4951-4d8f-975a-81212781dbc8', NULL, 0, 0, NULL, 1, 0, N'Guest@Vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a40ce824-7338-4ee1-925e-43d234c24b21', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'83bdb197-1ed9-4594-89d9-68cc99e0d603', N'a40ce824-7338-4ee1-925e-43d234c24b21')
");
        }
        
        public override void Down()
        {
        }
    }
}
