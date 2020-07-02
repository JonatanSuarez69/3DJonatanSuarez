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
    public class DetailsModel : PageModel
    {
        private readonly Proyectoint.Data.CandidatoContext _context;

        public DetailsModel(Proyectoint.Data.CandidatoContext context)
        {
            _context = context;
        }

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
    }
}
