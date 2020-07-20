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
    public class DeleteLabo : PageModel
    {
        private readonly Proyectoint.Data.LaboralContext _context;

        public DeleteLabo(Proyectoint.Data.LaboralContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Laboral Laboral { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Laboral = await _context.Laboral.FirstOrDefaultAsync(m => m.Empresa == id);

            if (Laboral == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Laboral = await _context.Laboral.FindAsync(id);

            if (Laboral != null)
            {
                _context.Laboral.Remove(Laboral);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
