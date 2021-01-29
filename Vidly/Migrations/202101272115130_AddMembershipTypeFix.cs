namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeFix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MembershipTypes", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.MembershipTypes", new[] { "MembershipTypeId" });
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "MembershipTypeId");
            AddForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "IsSubscrobedToNewsletter");
            DropColumn("dbo.MembershipTypes", "MembershipTypeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "IsSubscrobedToNewsletter", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Customers", "MembershipTypeId", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "MembershipTypeId" });
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropColumn("dbo.Customers", "IsSubscribedToNewsletter");
            CreateIndex("dbo.MembershipTypes", "MembershipTypeId");
            AddForeignKey("dbo.MembershipTypes", "MembershipTypeId", "dbo.MembershipTypes", "Id");
        }
    }
}
