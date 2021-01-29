namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRecordsIntoMembershipType1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pay As You go' WHERE Id = 1;");
            Sql("UPDATE MembershipTypes SET Name ='Monthly' WHERE Id = 2;");
            Sql("UPDATE MembershipTypes SET Name = 'Quarterly' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
