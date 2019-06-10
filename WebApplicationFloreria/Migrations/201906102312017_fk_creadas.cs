namespace WebApplicationFloreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fk_creadas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Flores", "especieId", c => c.Int(nullable: false));
            CreateIndex("dbo.Flores", "especieId");
            CreateIndex("dbo.Pedidoes", "DNI");
            AddForeignKey("dbo.Flores", "especieId", "dbo.Especies", "idEspecie", cascadeDelete: true);
            AddForeignKey("dbo.Pedidoes", "DNI", "dbo.Clientes", "DNI", cascadeDelete: true);
            DropColumn("dbo.Flores", "Especie");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Flores", "Especie", c => c.Int(nullable: false));
            DropForeignKey("dbo.Pedidoes", "DNI", "dbo.Clientes");
            DropForeignKey("dbo.Flores", "especieId", "dbo.Especies");
            DropIndex("dbo.Pedidoes", new[] { "DNI" });
            DropIndex("dbo.Flores", new[] { "especieId" });
            DropColumn("dbo.Flores", "especieId");
        }
    }
}
