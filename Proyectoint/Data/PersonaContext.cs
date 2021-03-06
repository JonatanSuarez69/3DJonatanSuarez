﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proyectoint.Models;

namespace Proyectoint.Data
{
    public class PersonaContext : DbContext
    {
        public PersonaContext (DbContextOptions<PersonaContext> options)
            : base(options)
        {
        }

        public DbSet<Proyectoint.Models.Persona> Persona { get; set; }

        public DbSet<Proyectoint.Models.Usuarios> Usuarios { get; set; }
    }
}
