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

namespace Proyectoint.Pages.Candidato
{
    public class EditModel : PageModel
    {
        private readonly Proyectoint.Data.CandiContext _context;

        public EditModel(Proyectoint.Data.CandiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candi Candi { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candi = await _context.Candi.FirstOrDefaultAsync(m => m.id == id);

            if (Candi == null)
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

            _context.Attach(Candi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandiExists(Candi.id))
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

        private bool CandiExists(int id)
        {
            return _context.Candi.Any(e => e.id == id);
        }
    }
}
