namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pastel03 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Produtoes", newName: "Produtos");
            AlterColumn("dbo.Produtos", "Nome_prd", c => c.String(nullable: false, maxLength: 150, unicode: false));
            AlterColumn("dbo.Produtos", "Valor_prd", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Valor_prd", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Produtos", "Nome_prd", c => c.String());
            RenameTable(name: "dbo.Produtos", newName: "Produtoes");
        }
    }
}
