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
    public class EmpresaModel : PageModel
    {
        private readonly Proyectoint.Data.EmpresaContext _context;

        public EmpresaModel(Proyectoint.Data.EmpresaContext context)
        {
            _context = context;
        }

        public IList<Empresa> Empresa { get;set; }

        public async Task OnGetAsync()
        {
            Empresa = await _context.Empresa.ToListAsync();
        }
    }
}
