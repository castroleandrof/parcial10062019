namespace WebApplicationFloreria.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplicationFloreria.Data.FloreriaDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplicationFloreria.Data.FloreriaDbContext context)
        {
            context.Cliente.AddOrUpdate(x => x.DNI,
               new Cliente() { DNI = 1, Nombre = "Jose", Telefono = "11111111" },
               new Cliente() { DNI = 2, Nombre = "Cristian", Telefono = "22222222" },
               new Cliente() { DNI = 3, Nombre = "Facundo", Telefono = "33333333" });

            context.Especie.AddOrUpdate(x => x.idEspecie,
                new Especie() { idEspecie = 1, Nombre = "Rosa" },
                new Especie() { idEspecie = 2, Nombre = "Girasol" },
                new Especie() { idEspecie = 3, Nombre = "Tulipan" });

            context.Pedido.AddOrUpdate(x => x.numPedido,
                new Pedido() { numPedido = 1, DNI = 1, FechaPedido = "10062019" },
                new Pedido() { numPedido = 2, DNI = 3, FechaPedido = "5062019" },
                new Pedido() { numPedido = 3, DNI = 2, FechaPedido = "01062019" });

            context.Flores.AddOrUpdate(x => x.CodigoFl,
                new Flores() { CodigoFl = 1, Nombre = "Flor1", Precio = 20, especieId = 1 },
                new Flores() { CodigoFl = 2, Nombre = "Flor2", Precio = 15, especieId = 2 },
                new Flores() { CodigoFl = 3, Nombre = "Flor3", Precio = 25, especieId = 3 });

            context.PedidoFlores.AddOrUpdate(x => x.cantidad,
                new PedidoFlores() { cantidad = 5, codigoFl = 1, idPedido = 2 },
                new PedidoFlores() { cantidad = 10, codigoFl = 2, idPedido = 1 },
                new PedidoFlores() { cantidad = 11, codigoFl = 3, idPedido = 3 });
        }
    }
}
