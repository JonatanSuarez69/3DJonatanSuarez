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
    public class DeleteModel : PageModel
    {
        private readonly Proyectoint.Data.CandidatoContext _context;

        public DeleteModel(Proyectoint.Data.CandidatoContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidato Candidato { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Candidato = await _context.Candidato.FirstOrDefaultAsync(m => m.IdCandidato == id);

            if (Candidato == null)
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

            Candidato = await _context.Candidato.FindAsync(id);

            if (Candidato != null)
            {
                _context.Candidato.Remove(Candidato);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
