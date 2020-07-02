using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class EmpresaContext : DbContext
    {
        public EmpresaContext (DbContextOptions<EmpresaContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Empresa> Empresa { get; set; }
    }
}
