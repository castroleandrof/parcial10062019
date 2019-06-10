namespace WebApplicationFloreria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        DNI = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Telefono = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.DNI);
            
            CreateTable(
                "dbo.Especies",
                c => new
                    {
                        idEspecie = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.idEspecie);
            
            CreateTable(
                "dbo.Flores",
                c => new
                    {
                        CodigoFl = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Precio = c.Int(nullable: false),
                        Especie = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CodigoFl);
            
            CreateTable(
                "dbo.PedidoFlores",
                c => new
                    {
                        cantidad = c.Int(nullable: false, identity: true),
                        idPedido = c.Int(nullable: false),
                        codigoFl = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cantidad)
                .ForeignKey("dbo.Flores", t => t.codigoFl, cascadeDelete: true)
                .ForeignKey("dbo.Pedidoes", t => t.idPedido, cascadeDelete: true)
                .Index(t => t.idPedido)
                .Index(t => t.codigoFl);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        numPedido = c.Int(nullable: false, identity: true),
                        FechaPedido = c.Int(nullable: false),
                        DNI = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.numPedido);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PedidoFlores", "idPedido", "dbo.Pedidoes");
            DropForeignKey("dbo.PedidoFlores", "codigoFl", "dbo.Flores");
            DropIndex("dbo.PedidoFlores", new[] { "codigoFl" });
            DropIndex("dbo.PedidoFlores", new[] { "idPedido" });
            DropTable("dbo.Pedidoes");
            DropTable("dbo.PedidoFlores");
            DropTable("dbo.Flores");
            DropTable("dbo.Especies");
            DropTable("dbo.Clientes");
        }
    }
}
