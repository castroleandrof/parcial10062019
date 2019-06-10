using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using static WebApplicationFloreria.Models.Flores;

namespace WebApplicationFloreria.Models
{
    public partial class Flores
    {
        public Flores() { }

        public int CodigoFl { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public Especie Especie { get; set; }
        public int especieId { get; set; }

        public ICollection<PedidoFlores> pedidoFlores { get; set; }
    }

    [MetadataType(typeof(FloresMetadata))]
    public partial class Flores
    {
        public class FloresMetadata
        {
            [Key]
            public int CodigoFl { get; set; }
            [Required]
            public string Nombre { get; set; }
            [Required]
            public int Precio { get; set; }
            [ForeignKey("especieId")]
            public Especie Especie { get; set; }
        }
    }

}
