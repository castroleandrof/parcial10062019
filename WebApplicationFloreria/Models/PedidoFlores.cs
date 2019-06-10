using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static WebApplicationFloreria.Models.Pedido;

namespace WebApplicationFloreria.Models
{
    public partial class PedidoFlores
    {
        public PedidoFlores() { }

        public Pedido Pedido { get; set; }
        public Flores Flores { get; set; }
        public int idPedido { get; set; }
        public int codigoFl { get; set; }
        public int cantidad { get; set; }
    }

    [MetadataType(typeof(PedidoFloresMetadata))]
    public partial class PedidoFlores
    {
        public class PedidoFloresMetadata
        {
            [Key]
            [ForeignKey("idPedido")]
            public Pedido Pedido { get; set; }

            [Key,ForeignKey("codigoFl")]
            public Flores Flores { get; set; }

            [Required]
            public int cantidad { get; set; }

        }
    }
}