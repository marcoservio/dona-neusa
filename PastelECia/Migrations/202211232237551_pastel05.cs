namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pastel05 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Enderecoes", newName: "Endereco");
            RenameColumn(table: "dbo.Cliente", name: "Id", newName: "Id_cli");
            RenameColumn(table: "dbo.Cliente", name: "CnpjCpf", newName: "CnpjCpf_cli");
            RenameColumn(table: "dbo.Cliente", name: "Telefone", newName: "Telefone_cli");
            RenameColumn(table: "dbo.Cliente", name: "Email", newName: "IdEndereco_cli");
            RenameColumn(table: "dbo.Endereco", name: "Id", newName: "Id_end");
            RenameColumn(table: "dbo.Endereco", name: "Locradouro", newName: "Locradouro_end");
            RenameColumn(table: "dbo.Endereco", name: "Numero", newName: "Numero_end");
            RenameColumn(table: "dbo.Endereco", name: "Complemento", newName: "Complemento_end");
            RenameColumn(table: "dbo.Endereco", name: "Bairro", newName: "Bairro_end");
            RenameColumn(table: "dbo.Endereco", name: "Cidade", newName: "Cidade_end");
            RenameColumn(table: "dbo.Endereco", name: "Pais", newName: "Pais_end");
            RenameColumn(table: "dbo.Endereco", name: "Estado", newName: "Estado_end");
            RenameColumn(table: "dbo.Endereco", name: "Cep", newName: "Cep_end");
            RenameColumn(table: "dbo.Produto", name: "Id", newName: "Id_prd");
            RenameColumn(table: "dbo.Produto", name: "Quantidade", newName: "Quantidade_prd");
            CreateTable(
                "dbo.Parametro",
                c => new
                    {
                        Id_par = c.Int(nullable: false, identity: true),
                        DiaLimiteAcesso_par = c.Int(nullable: false),
                        CodigoAtivacao_par = c.String(nullable: false, maxLength: 30, unicode: false),
                    })
                .PrimaryKey(t => t.Id_par);
            
            CreateTable(
                "dbo.VersaoSistema",
                c => new
                    {
                        Id_vsi = c.Int(nullable: false, identity: true),
                        VersaoSistema_vsi = c.Int(nullable: false),
                        VersaoBanco_vsi = c.Int(nullable: false),
                        Revisao_vsi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id_vsi);
            
            AlterColumn("dbo.Cliente", "Nome_cli", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.Cliente", "CnpjCpf_cli", c => c.String(nullable: false, maxLength: 14, unicode: false));
            AlterColumn("dbo.Cliente", "Telefone_cli", c => c.String(maxLength: 11, unicode: false));
            AlterColumn("dbo.Cliente", "IdEndereco_cli", c => c.String(maxLength: 50, unicode: false));
            AlterColumn("dbo.Endereco", "Locradouro_end", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.Endereco", "Numero_end", c => c.Int(nullable: false));
            AlterColumn("dbo.Endereco", "Complemento_end", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Endereco", "Bairro_end", c => c.String(nullable: false, maxLength: 60, unicode: false));
            AlterColumn("dbo.Endereco", "Cidade_end", c => c.String(nullable: false, maxLength: 60, unicode: false));
            AlterColumn("dbo.Endereco", "Pais_end", c => c.String(nullable: false, maxLength: 40, unicode: false));
            AlterColumn("dbo.Endereco", "Estado_end", c => c.String(nullable: false, maxLength: 60, unicode: false));
            AlterColumn("dbo.Endereco", "Cep_end", c => c.String(nullable: false, maxLength: 8, unicode: false));
            AlterColumn("dbo.Produto", "Nome_prd", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produto", "Nome_prd", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Endereco", "Cep_end", c => c.String());
            AlterColumn("dbo.Endereco", "Estado_end", c => c.String());
            AlterColumn("dbo.Endereco", "Pais_end", c => c.String());
            AlterColumn("dbo.Endereco", "Cidade_end", c => c.String());
            AlterColumn("dbo.Endereco", "Bairro_end", c => c.String());
            AlterColumn("dbo.Endereco", "Complemento_end", c => c.String());
            AlterColumn("dbo.Endereco", "Numero_end", c => c.String());
            AlterColumn("dbo.Endereco", "Locradouro_end", c => c.String());
            AlterColumn("dbo.Cliente", "IdEndereco_cli", c => c.String());
            AlterColumn("dbo.Cliente", "Telefone_cli", c => c.String());
            AlterColumn("dbo.Cliente", "CnpjCpf_cli", c => c.String());
            AlterColumn("dbo.Cliente", "Nome_cli", c => c.String(nullable: false, maxLength: 150, unicode: false));
            DropTable("dbo.VersaoSistema");
            DropTable("dbo.Parametro");
            RenameColumn(table: "dbo.Produto", name: "Quantidade_prd", newName: "Quantidade");
            RenameColumn(table: "dbo.Produto", name: "Id_prd", newName: "Id");
            RenameColumn(table: "dbo.Endereco", name: "Cep_end", newName: "Cep");
            RenameColumn(table: "dbo.Endereco", name: "Estado_end", newName: "Estado");
            RenameColumn(table: "dbo.Endereco", name: "Pais_end", newName: "Pais");
            RenameColumn(table: "dbo.Endereco", name: "Cidade_end", newName: "Cidade");
            RenameColumn(table: "dbo.Endereco", name: "Bairro_end", newName: "Bairro");
            RenameColumn(table: "dbo.Endereco", name: "Complemento_end", newName: "Complemento");
            RenameColumn(table: "dbo.Endereco", name: "Numero_end", newName: "Numero");
            RenameColumn(table: "dbo.Endereco", name: "Locradouro_end", newName: "Locradouro");
            RenameColumn(table: "dbo.Endereco", name: "Id_end", newName: "Id");
            RenameColumn(table: "dbo.Cliente", name: "IdEndereco_cli", newName: "Email");
            RenameColumn(table: "dbo.Cliente", name: "Telefone_cli", newName: "Telefone");
            RenameColumn(table: "dbo.Cliente", name: "CnpjCpf_cli", newName: "CnpjCpf");
            RenameColumn(table: "dbo.Cliente", name: "Id_cli", newName: "Id");
            RenameTable(name: "dbo.Endereco", newName: "Enderecoes");
        }
    }
}
