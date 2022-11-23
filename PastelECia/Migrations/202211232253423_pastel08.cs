namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pastel08 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Produto", name: "Quantidade_prd", newName: "Quantidade");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Produto", name: "Quantidade", newName: "Quantidade_prd");
        }
    }
}
