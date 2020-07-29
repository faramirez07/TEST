namespace Test.Model.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeRiskM : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypeRiskM",
                c => new
                    {
                        IdRisk = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdRisk);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TypeRiskM");
        }
    }
}
