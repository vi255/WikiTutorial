namespace WikiTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionaIdadeNoCliente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "Idade", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "Idade");
        }
    }
}
