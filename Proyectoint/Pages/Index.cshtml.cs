﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyectoint
{
    public class IndexModel : PageModel
    {

        public string Nombre_Usuario { get; set; }
        
        public string Contraseña { get; set; }

        public void OnGet()
        {

        }
    }
}