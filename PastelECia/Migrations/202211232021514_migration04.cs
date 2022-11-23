namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration04 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtos", newName: "Produto");
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome_cli = c.String(nullable: false, maxLength: 150, unicode: false),
                        CnpjCpf = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Endereco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Enderecoes", t => t.Endereco_Id)
                .Index(t => t.Endereco_Id);
            
            CreateTable(
                "dbo.Enderecoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Locradouro = c.String(),
                        Numero = c.String(),
                        Complemento = c.String(),
                        Bairro = c.String(),
                        Cidade = c.String(),
                        Pais = c.String(),
                        Estado = c.String(),
                        Cep = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cliente", "Endereco_Id", "dbo.Enderecoes");
            DropIndex("dbo.Cliente", new[] { "Endereco_Id" });
            DropTable("dbo.Enderecoes");
            DropTable("dbo.Cliente");
            RenameTable(name: "dbo.Produto", newName: "Produtos");
        }
    }
}
