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
    public class UsersModel : PageModel
    {
        private readonly Proyectoint.Data.UsuariosContext _context;

        public UsersModel(Proyectoint.Data.UsuariosContext context)
        {
            _context = context;
        }

        public IList<Usuarios> Usuarios { get;set; }

        public async Task OnGetAsync()
        {
            Usuarios = await _context.Usuarios.ToListAsync();
        }
    }
}
