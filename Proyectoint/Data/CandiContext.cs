using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class CandiContext : DbContext
    {
        public CandiContext (DbContextOptions<CandiContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Candi> Candi { get; set; }
    }
}
