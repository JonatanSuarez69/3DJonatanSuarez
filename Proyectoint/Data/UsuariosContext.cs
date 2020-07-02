using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class UsuariosContext : DbContext
    {
        public UsuariosContext (DbContextOptions<UsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Usuarios> Usuarios { get; set; }
    }
}
