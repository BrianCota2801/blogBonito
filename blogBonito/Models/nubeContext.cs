using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace blogBonito.Models
{
    public partial class nubeContext : DbContext
    {
        public nubeContext()
        {
        }

        public nubeContext(DbContextOptions<nubeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Libro> Libros { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=ec2-3-145-45-9.us-east-2.compute.amazonaws.com;user=paola;password=admin;database=nube", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.1.0-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("libros");

                entity.Property(e => e.Calificacion).HasPrecision(3, 2);

                entity.Property(e => e.Descripcion).HasColumnType("text");

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Reseña).HasColumnType("text");

                entity.Property(e => e.UrlImagen)
                    .HasMaxLength(255)
                    .HasColumnName("urlImagen");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
