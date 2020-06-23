using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyectoint.Pages
{
    public class InicioModel : PageModel
    {

        public int Id_Usuarios { get; set; }
     
        public string Nombre_Usuario { get; set; }
        
        
        public string Contraseņa { get; set; }

        public void OnGet()
        {
        }
    }
}
