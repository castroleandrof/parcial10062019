using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationFloreria.Models
{
    public partial class Especie
    {
        public Especie() { }

        public int idEspecie { get; set; }
        public string Nombre { get; set; }

        public ICollection<Flores> Flores { get; set; }

    }

    [MetadataType(typeof(EspecieMetadata))]
    public partial class Especie
    {
        public class EspecieMetadata
        {
            [Key]
            public int idEspecie { get; set; }
            [Required]
            public string Nombre { get; set; }
        }
    }
}