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
    public class DetailLabo : PageModel
    {
        private readonly Proyectoint.Data.LaboralContext _context;

        public DetailLabo(Proyectoint.Data.LaboralContext context)
        {
            _context = context;
        }

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
    }
}
