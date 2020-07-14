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
    public class CreateHisto : PageModel
    {
        private readonly Proyectoint.Data.Historial1Context _context;

        public CreateHisto(Proyectoint.Data.Historial1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Historial1 Historial1 { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Historial1.Add(Historial1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
