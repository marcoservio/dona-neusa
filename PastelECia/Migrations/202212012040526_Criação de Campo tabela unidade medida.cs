namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriaçãodeCampotabelaunidademedida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UnidadeMedida", "Descricao_umd", c => c.String(maxLength: 70, unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UnidadeMedida", "Descricao_umd");
        }
    }
}
