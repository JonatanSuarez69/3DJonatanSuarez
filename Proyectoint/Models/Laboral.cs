using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectoint.Models
{
    public class Laboral
    {
        public string Nombre { get; set;}
        [Key]
        public string Empresa { get; set; }

        public string Direc { get; set; }

        public string Razon { get; set; }
        [Display(Name = "Puesto anterior", Prompt = "Puesto anterior")]
        public string PuestoAnt { get; set; }
        [Display(Name = "Inicion de laboracion", Prompt = "Inicio de laboracion")]
        public DateTime InicioLabo { get; set; }
        [Display(Name = "Fin de laboracion", Prompt = "Fin de laboracion")]
        public DateTime FinLABO { get; set; }



    }
}
