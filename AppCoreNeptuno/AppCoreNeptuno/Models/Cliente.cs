using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppCoreNeptuno.Models
{
    public class Cliente
    {
        [Key]
        public string IdCliente { get; set; }
        public string NombreCompañía { get; set; }
        public string Dirección { get; set; }
        public string Ciudad { get; set; }
        public string País { get; set; }
        public string Teléfono { get; set; }

    }
}
