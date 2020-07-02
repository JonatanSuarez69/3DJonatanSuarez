using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoint.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }

        public string NombreEmp { get; set; }

        public string Direccion { get; set; }

        public int Tel { get; set; }



    }
}
