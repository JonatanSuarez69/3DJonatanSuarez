using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoint.Models
{
    public class Historial1
    {
        [Key]
       public int id_histo { get; set; }

        [Required(ErrorMessage = "Se requiere el nombre del candidato")]
        [Display(Name ="Nombre del candidato")]
        public string Nombre_candidato { get; set; }

        [Required(ErrorMessage = "Se requiere su direccion")]
        public int Direccion { get; set; }

        [Required(ErrorMessage = "Se requiere la empresa")]
        [Display(Name ="Empresa de procedencia")]
        public string Empresa_pro { get; set; }

        [Required(ErrorMessage = "Se requiere su puesto anterior")]
        public string Desempeño { get; set; }


        public string Observaciones { get; set; }



    }
}
