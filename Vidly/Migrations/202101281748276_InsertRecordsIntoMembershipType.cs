namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertRecordsIntoMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name ='Pago a Medida Que Avanza' WHERE Id = 1;");
            Sql("UPDATE MembershipTypes SET Name ='Mensual' WHERE Id = 2;");
            Sql("UPDATE MembershipTypes SET Name = 'Cuatrimestral' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Name = 'Anual' WHERE Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
