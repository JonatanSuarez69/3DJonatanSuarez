using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Data;
using Proyectoint.Models;

namespace Proyectoint
{
    public class DetailsUser : PageModel
    {
        private readonly Proyectoint.Data.UsuariosContext _context;

        public DetailsUser(Proyectoint.Data.UsuariosContext context)
        {
            _context = context;
        }

        public Usuarios Usuarios { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuarios = await _context.Usuarios.FirstOrDefaultAsync(m => m.Id_usuario == id);

            if (Usuarios == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
