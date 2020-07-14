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
    public class DetailsHisto : PageModel
    {
        private readonly Proyectoint.Data.Historial1Context _context;

        public DetailsHisto(Proyectoint.Data.Historial1Context context)
        {
            _context = context;
        }

        public Historial1 Historial1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Historial1 = await _context.Historial1.FirstOrDefaultAsync(m => m.id_histo == id);

            if (Historial1 == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
