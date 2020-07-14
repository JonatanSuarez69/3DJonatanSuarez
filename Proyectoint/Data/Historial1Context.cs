using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class Historial1Context : DbContext
    {
        public Historial1Context (DbContextOptions<Historial1Context> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Historial1> Historial1 { get; set; }
    }
}
