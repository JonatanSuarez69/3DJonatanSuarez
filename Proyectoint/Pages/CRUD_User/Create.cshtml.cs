using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proyectoint.Data;
using Proyectoint.Models;

namespace Proyectoint
{
    public class CreateUser : PageModel
    {
        private readonly Proyectoint.Data.UsuariosContext _context;

        public CreateUser(Proyectoint.Data.UsuariosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Usuarios Usuarios { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Usuarios.Add(Usuarios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Users");
        }
    }
}
