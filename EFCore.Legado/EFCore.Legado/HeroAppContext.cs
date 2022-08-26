using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class HeroAppContext : DbContext
    {
        public HeroAppContext()
        {
        }

        public HeroAppContext(DbContextOptions<HeroAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Armas> Armas { get; set; }
        public virtual DbSet<Batalhas> Batalhas { get; set; }
        public virtual DbSet<Herois> Herois { get; set; }
        public virtual DbSet<HeroisBatalhas> HeroisBatalhas { get; set; }
        public virtual DbSet<IdentidadesSecretas> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("string de conexão aqui");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Armas>(entity =>
            {
                entity.HasIndex(e => e.HeroiId);

                entity.HasIndex(e => e.IdentidadeSecretaId);

                entity.HasOne(d => d.Heroi)
                    .WithMany(p => p.Armas)
                    .HasForeignKey(d => d.HeroiId);

                entity.HasOne(d => d.IdentidadeSecreta)
                    .WithMany(p => p.Armas)
                    .HasForeignKey(d => d.IdentidadeSecretaId);
            });

            modelBuilder.Entity<Batalhas>(entity =>
            {
                entity.HasIndex(e => new { e.HeroiBatalhaBatalhaId, e.HeroiBatalhaHeroiId });

                entity.HasOne(d => d.HeroiBatalha)
                    .WithMany(p => p.Batalhas)
                    .HasForeignKey(d => new { d.HeroiBatalhaBatalhaId, d.HeroiBatalhaHeroiId });
            });

            modelBuilder.Entity<Herois>(entity =>
            {
                entity.HasIndex(e => new { e.HeroiBatalhaBatalhaId, e.HeroiBatalhaHeroiId });

                entity.HasOne(d => d.HeroiBatalha)
                    .WithMany(p => p.Herois)
                    .HasForeignKey(d => new { d.HeroiBatalhaBatalhaId, d.HeroiBatalhaHeroiId });
            });

            modelBuilder.Entity<HeroisBatalhas>(entity =>
            {
                entity.HasKey(e => new { e.BatalhaId, e.HeroiId });

                entity.HasIndex(e => e.IdentidadeSecretaId);

                entity.HasOne(d => d.IdentidadeSecreta)
                    .WithMany(p => p.HeroisBatalhas)
                    .HasForeignKey(d => d.IdentidadeSecretaId);
            });

            modelBuilder.Entity<IdentidadesSecretas>(entity =>
            {
                entity.HasIndex(e => e.IdentidadeId);

                entity.HasOne(d => d.Identidade)
                    .WithMany(p => p.InverseIdentidade)
                    .HasForeignKey(d => d.IdentidadeId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
