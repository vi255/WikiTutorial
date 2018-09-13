namespace WikiTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaEmailNoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Email");
        }
    }
}
