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
    public class IndexModel : PageModel
    {
        private readonly Proyectoint.Data.CandiContext _context;

        public IndexModel(Proyectoint.Data.CandiContext context)
        {
            _context = context;
        }

        public IList<Candi> Candi { get;set; }

        public async Task OnGetAsync()
        {
            Candi = await _context.Candi.ToListAsync();
        }
    }
}
