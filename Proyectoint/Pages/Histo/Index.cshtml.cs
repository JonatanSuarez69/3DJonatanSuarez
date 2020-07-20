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
    public class ModelLabo : PageModel
    {
        private readonly Proyectoint.Data.LaboralContext _context;

        public ModelLabo(Proyectoint.Data.LaboralContext context)
        {
            _context = context;
        }

        public IList<Laboral> Laboral { get;set; }

        public async Task OnGetAsync()
        {
            Laboral = await _context.Laboral.ToListAsync();
        }
    }
}
