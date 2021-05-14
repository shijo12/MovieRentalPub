namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropppingBirthdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
        
        public override void Down()
        {
        }
    }
}
