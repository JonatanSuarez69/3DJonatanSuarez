using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class LaboralContext : DbContext
    {
        public LaboralContext (DbContextOptions<LaboralContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Laboral> Laboral { get; set; }
    }
}
