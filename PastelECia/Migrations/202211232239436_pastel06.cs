namespace PastelECia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pastel06 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Cliente", name: "IdEndereco_cli", newName: "Email_cli");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Cliente", name: "Email_cli", newName: "IdEndereco_cli");
        }
    }
}
