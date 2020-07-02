using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Proyectoint.Models
{
    public partial class Proyecto_integradorContext : DbContext
    {
        public Proyecto_integradorContext()
        {
        }

        public Proyecto_integradorContext(DbContextOptions<Proyecto_integradorContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuarios> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

               // optionsBuilder.UseSqlServer("Data Source=ATALIA;Initial Catalog=Proyecto_integrador;User ID=Jonatan3D;Password=Solovino000;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.Id_usuario);

                entity.Property(e => e.Id_usuario).HasColumnName("Id_usuario");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre_Usuario)
                    .IsRequired()
                    .HasColumnName("Nombre_Usuario")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
