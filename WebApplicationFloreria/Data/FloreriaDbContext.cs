using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using WebApplicationFloreria.Models;

namespace WebApplicationFloreria.Data
{
    public class FloreriaDbContext : DbContext
    {
        public FloreriaDbContext():base("FloreriaDbContext")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Especie> Especie { get; set; }
        public DbSet<Flores> Flores { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoFlores> PedidoFlores { get; set; }
    }
}