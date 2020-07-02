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
    public class CreateEmpresa : PageModel
    {
        private readonly Proyectoint.Data.EmpresaContext _context;

        public CreateEmpresa(Proyectoint.Data.EmpresaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Empresa Empresa { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Empresa.Add(Empresa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
