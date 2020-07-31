using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using Proyectoint.Reporte;
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

        public string Nombre_Completo { get; set; }

        public string Sexo { get; set; }

        public DateTime Cumple { get; set; }

        public string Est_civ { get; set; }

        public string Nacionalidad { get; set; }

        public string Curp { get; set; }

        public string Referencia { get; set; }




    }
}
