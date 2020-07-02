using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Data;
using Proyectoint.Models;

namespace Proyectoint
{
    public class EditUser : PageModel
    {
        private readonly Proyectoint.Data.UsuariosContext _context;

        public EditUser(Proyectoint.Data.UsuariosContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Usuarios).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuariosExists(Usuarios.Id_usuario))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Users");
        }

        private bool UsuariosExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id_usuario == id);
        }
    }
}
