using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApiLaboratorio.Models
{
    public partial class controLaboratorioContext : DbContext
    {
        public controLaboratorioContext()
        {
        }

        public controLaboratorioContext(DbContextOptions<controLaboratorioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Carrera> Carreras { get; set; }
        public virtual DbSet<Edificio> Edificios { get; set; }
        public virtual DbSet<Laboratorio> Laboratorios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-B6CFPI6;Database=controLaboratorio;user=sa;password=123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera);

                entity.ToTable("CARRERAS");

                entity.Property(e => e.IdCarrera).HasColumnName("ID_CARRERA");

                entity.Property(e => e.Alias)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ALIAS");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.UrlImg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("URL_IMG");
            });

            modelBuilder.Entity<Edificio>(entity =>
            {
                entity.HasKey(e => e.IdEdificio)
                    .HasName("PK__EDIFICIO__0F993A860DD72723");

                entity.ToTable("EDIFICIOS");

                entity.Property(e => e.IdEdificio).HasColumnName("ID_EDIFICIO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.UrlImg)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("URL_IMG");
            });

            modelBuilder.Entity<Laboratorio>(entity =>
            {
                entity.HasKey(e => e.IdLaboratorio)
                    .HasName("PK__LABORATO__6D929FB9879FBDE4");

                entity.ToTable("LABORATORIOS");

                entity.Property(e => e.IdLaboratorio).HasColumnName("ID_LABORATORIO");

                entity.Property(e => e.FkIdEdifico).HasColumnName("FK_ID_EDIFICO");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.UrlImg)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("URL_IMG");

                entity.HasOne(d => d.FkIdEdificoNavigation)
                    .WithMany(p => p.Laboratorios)
                    .HasForeignKey(d => d.FkIdEdifico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__LABORATOR__FK_ID__5DCAEF64");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
