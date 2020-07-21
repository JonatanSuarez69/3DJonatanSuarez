using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Data;
using Proyectoint.Models;

namespace Proyectoint.Pages.Candidato
{
    public class DetailsModel : PageModel
    {
        private readonly Proyectoint.Data.CandiContext _context;

        public DetailsModel(Proyectoint.Data.CandiContext context)
        {
            _context = context;
        }

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
    }
}
