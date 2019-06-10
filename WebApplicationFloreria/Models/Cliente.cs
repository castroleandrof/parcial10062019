using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationFloreria.Models
{
    public partial class Cliente
    {
        public Cliente()
        { }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
    }

    [MetadataType(typeof(ClienteMetadata))]
    public partial class Cliente
    {
        public class ClienteMetadata
        {
            [Key]
            public int DNI { get; set; }
            [Required]
            public string Nombre { get; set; }
            [Required]
            public string Telefono { get; set; }
        }
    }
}