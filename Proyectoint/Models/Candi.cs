using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoint.Models
{
    public class Candi
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Nombre del candidato")]
        public string Nombre_Completo { get; set; }

        public string Sexo { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime Cumple { get; set; }
        [Display(Name = "Estado civil")]
        public string Est_civ { get; set; }

        public string Nacionalidad { get; set; }

        public string Curp { get; set; }
        [Display(Name = "¿Cuenta con referencia laboral?")]
        public string Referencia { get; set; }

    }
}
