namespace Test.Model.Migration.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Policy : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ClientM");
            DropTable("dbo.PolicyM");
            DropTable("dbo.PolicyClientM");
            DropTable("dbo.TypePolicyM");
            DropTable("dbo.TypeRiskM");
        }
        
        public override void Down()
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
            
            CreateTable(
                "dbo.TypePolicyM",
                c => new
                    {
                        IdPolicy = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IdPolicy);
            
            CreateTable(
                "dbo.PolicyClientM",
                c => new
                    {
                        IdPolicyClient = c.Int(nullable: false, identity: true),
                        IdClient = c.Int(nullable: false),
                        IdPolicy = c.Int(nullable: false),
                        CoveragePercentage = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        UserCreate = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPolicyClient);
            
            CreateTable(
                "dbo.PolicyM",
                c => new
                    {
                        IdPolicy = c.Int(nullable: false, identity: true),
                        TypePolicy = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        Start = c.String(),
                        Duration = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeRisk = c.String(),
                        UserCreate = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdPolicy);
            
            CreateTable(
                "dbo.ClientM",
                c => new
                    {
                        IdClient = c.Int(nullable: false, identity: true),
                        Id = c.Int(nullable: false),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Nationality = c.String(),
                        Active = c.Boolean(nullable: false),
                        UserCreate = c.String(),
                        DateCreate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdClient);
            
        }
    }
}
