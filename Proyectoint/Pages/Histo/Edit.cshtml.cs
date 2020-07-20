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
    public class EditLabo : PageModel
    {
        private readonly Proyectoint.Data.LaboralContext _context;

        public EditLabo(Proyectoint.Data.LaboralContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Laboral).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LaboralExists(Laboral.Empresa))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LaboralExists(string id)
        {
            return _context.Laboral.Any(e => e.Empresa == id);
        }
    }
}
