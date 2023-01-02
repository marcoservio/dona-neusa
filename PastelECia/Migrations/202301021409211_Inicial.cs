namespace ERP_DONA_NEUSA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        Id_cli = c.Int(nullable: false, identity: true),
                        Nome_cli = c.String(nullable: false, maxLength: 70, unicode: false),
                        CnpjCpf_cli = c.String(nullable: false, maxLength: 14, unicode: false),
                        Telefone_cli = c.String(maxLength: 11, unicode: false),
                        Email_cli = c.String(maxLength: 50, unicode: false),
                        Inativo_cli = c.Int(nullable: false),
                        DataAlteracao_cli = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_cli);
            
            CreateTable(
                "dbo.Endereco",
                c => new
                    {
                        ClienteId_end = c.Int(nullable: false),
                        Locradouro_end = c.String(nullable: false, maxLength: 100, unicode: false),
                        Numero_end = c.Int(nullable: false),
                        Complemento_end = c.String(maxLength: 100, unicode: false),
                        Bairro_end = c.String(nullable: false, maxLength: 60, unicode: false),
                        Cidade_end = c.String(nullable: false, maxLength: 60, unicode: false),
                        Pais_end = c.String(nullable: false, maxLength: 40, unicode: false),
                        Estado_end = c.String(nullable: false, maxLength: 60, unicode: false),
                        Cep_end = c.String(nullable: false, maxLength: 8, unicode: false),
                        Inativo_end = c.Int(nullable: false),
                        DataAlteracao_end = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId_end)
                .ForeignKey("dbo.Cliente", t => t.ClienteId_end, cascadeDelete: true)
                .Index(t => t.ClienteId_end);
            
            CreateTable(
                "dbo.Parametro",
                c => new
                    {
                        Id_par = c.Int(nullable: false, identity: true),
                        DataLimiteAcesso_par = c.DateTime(nullable: false),
                        CodigoAtivacao_par = c.String(nullable: false, maxLength: 30, unicode: false),
                        Inativo_par = c.Int(nullable: false),
                        DataAlteracao_par = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_par);
            
            CreateTable(
                "dbo.Produto",
                c => new
                    {
                        Id_prd = c.Int(nullable: false, identity: true),
                        Nome_prd = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descricao_prd = c.String(maxLength: 70, unicode: false),
                        Valor_prd = c.Decimal(nullable: false, precision: 10, scale: 2),
                        Quantidade_prd = c.Int(nullable: false),
                        DataAlteracao_prd = c.DateTime(nullable: false),
                        Inativo_prd = c.Int(nullable: false),
                        UnidadeMedidaId_prd = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_prd)
                .ForeignKey("dbo.UnidadeMedida", t => t.UnidadeMedidaId_prd, cascadeDelete: false)
                .Index(t => t.UnidadeMedidaId_prd);
            
            CreateTable(
                "dbo.UnidadeMedida",
                c => new
                    {
                        Id_umd = c.Int(nullable: false, identity: true),
                        Nome_umd = c.String(nullable: false, maxLength: 70, unicode: false),
                        Descricao_umd = c.String(maxLength: 70, unicode: false),
                        Inativo_umd = c.Int(nullable: false),
                        DataAlteracao_umd = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_umd);
            
            CreateTable(
                "dbo.VersaoSistema",
                c => new
                    {
                        Id_vsi = c.Int(nullable: false, identity: true),
                        VersaoSistema_vsi = c.Int(nullable: false),
                        VersaoBanco_vsi = c.Int(nullable: false),
                        Revisao_vsi = c.Int(nullable: false),
                        Inativo_vsi = c.Int(nullable: false),
                        DataAlteracao_vsi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id_vsi);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "UnidadeMedidaId_prd", "dbo.UnidadeMedida");
            DropForeignKey("dbo.Endereco", "ClienteId_end", "dbo.Cliente");
            DropIndex("dbo.Produto", new[] { "UnidadeMedidaId_prd" });
            DropIndex("dbo.Endereco", new[] { "ClienteId_end" });
            DropTable("dbo.VersaoSistema");
            DropTable("dbo.UnidadeMedida");
            DropTable("dbo.Produto");
            DropTable("dbo.Parametro");
            DropTable("dbo.Endereco");
            DropTable("dbo.Cliente");
        }
    }
}
