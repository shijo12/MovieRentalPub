namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertingIntoBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '02/04/1994' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
