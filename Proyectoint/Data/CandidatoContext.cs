using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class CandidatoContext : DbContext
    {
        public CandidatoContext (DbContextOptions<CandidatoContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Candidato> Candidato { get; set; }
    }
}
