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
    public class CandidatoModel : PageModel
    {
        private readonly Proyectoint.Data.CandidatoContext _context;

        public CandidatoModel(Proyectoint.Data.CandidatoContext context)
        {
            _context = context;
        }

        public IList<Candidato> Candidato { get;set; }

        public async Task OnGetAsync()
        {
            Candidato = await _context.Candidato.ToListAsync();
        }
    }
}
