namespace WebApplicationFloreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seed : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pedidoes", "FechaPedido", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pedidoes", "FechaPedido", c => c.Int(nullable: false));
        }
    }
}
