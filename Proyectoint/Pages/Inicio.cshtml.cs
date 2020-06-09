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
        [BindProperty]
        public string Usuario { get; set; }
        [BindProperty]
        public string Contraseña { get; set; }


        public void OnGet()
        {
        }
    }
}
