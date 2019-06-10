using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplicationFloreria.Models
{
    public partial class Pedido
    {
        public Pedido() { }

        public Cliente cliente { get; set; }
        public int numPedido { get; set; }
        public string FechaPedido { get; set; }
        public int DNI { get; set; }

        public ICollection<PedidoFlores> pedidoFlores { get;set; }
    }

    [MetadataType(typeof(PedidoMetadata))]
    public partial class Pedido
    {
        public class PedidoMetadata
        {
            [Key]
            public int numPedido { get; set; }
            [Required]
            public string FechaPedido { get; set; }
            [ForeignKey("DNI")]
            public Cliente cliente { get; set; }
        }
    }
}