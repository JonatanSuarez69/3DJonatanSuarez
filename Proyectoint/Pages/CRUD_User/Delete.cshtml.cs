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
    public class DeleteUser : PageModel
    {
        private readonly Proyectoint.Data.UsuariosContext _context;

        public DeleteUser(Proyectoint.Data.UsuariosContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuarios = await _context.Usuarios.FindAsync(id);

            if (Usuarios != null)
            {
                _context.Usuarios.Remove(Usuarios);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Users");
        }
    }
}
