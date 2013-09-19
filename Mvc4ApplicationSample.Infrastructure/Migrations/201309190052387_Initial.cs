namespace Mvc4ApplicationSample.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MarcaId = c.Int(nullable: false),
                        Modelo = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Marcas", t => t.MarcaId)
                .Index(t => t.MarcaId);
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarroPessoa",
                c => new
                    {
                        Carro_Id = c.Int(nullable: false),
                        Pessoa_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Carro_Id, t.Pessoa_Id })
                .ForeignKey("dbo.Carros", t => t.Carro_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pessoas", t => t.Pessoa_Id, cascadeDelete: true)
                .Index(t => t.Carro_Id)
                .Index(t => t.Pessoa_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CarroPessoa", new[] { "Pessoa_Id" });
            DropIndex("dbo.CarroPessoa", new[] { "Carro_Id" });
            DropIndex("dbo.Carros", new[] { "MarcaId" });
            DropForeignKey("dbo.CarroPessoa", "Pessoa_Id", "dbo.Pessoas");
            DropForeignKey("dbo.CarroPessoa", "Carro_Id", "dbo.Carros");
            DropForeignKey("dbo.Carros", "MarcaId", "dbo.Marcas");
            DropTable("dbo.CarroPessoa");
            DropTable("dbo.Pessoas");
            DropTable("dbo.Marcas");
            DropTable("dbo.Carros");
            DropTable("dbo.Usuarios");
        }
    }
}
