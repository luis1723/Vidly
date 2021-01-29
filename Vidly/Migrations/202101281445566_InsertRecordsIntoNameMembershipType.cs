namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRecordsIntoNameMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pay As You go' WHERE Id = 1;");
            Sql("UPDATE MembershipTypes SET Name ='Monthly' WHERE Id = 2;");

        }
        
        public override void Down()
        {
        }
    }
}
