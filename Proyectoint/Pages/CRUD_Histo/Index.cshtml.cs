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
    public class ModelHisto : PageModel
    {
        private readonly Proyectoint.Data.Historial1Context _context;

        public ModelHisto(Proyectoint.Data.Historial1Context context)
        {
            _context = context;
        }

        public IList<Historial1> Historial1 { get;set; }

        public async Task OnGetAsync()
        {
            Historial1 = await _context.Historial1.ToListAsync();
        }
    }
}
