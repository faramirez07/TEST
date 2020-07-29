namespace Test.ModelMigration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClientM : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Client", newName: "ClientM");
            RenameTable(name: "dbo.Policy", newName: "PolicyM");
            RenameTable(name: "dbo.PolicyClient", newName: "PolicyClientM");
            RenameTable(name: "dbo.TypePolicy", newName: "TypePolicyM");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TypePolicyM", newName: "TypePolicy");
            RenameTable(name: "dbo.PolicyClientM", newName: "PolicyClient");
            RenameTable(name: "dbo.PolicyM", newName: "Policy");
            RenameTable(name: "dbo.ClientM", newName: "Client");
        }
    }
}
