using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Arma> Armas { get; set; }
        public DbSet<HeroiBatalha> HeroisBatalhas { get; set; }
        public DbSet<IdentidadeSecreta> IdentidadesSecretas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=estudos_leo;Persist Security Info=True;User ID=estudos_leo;Initial Catalog=HeroApp;Data Source=DESKTOP-I1223JC\SQLEXPRESS");
        }

        /// <summary>
        /// Esse override server para poder identificar as as chave primaria de uma clase quando for necessário,
        /// para esse teste, no caso da classe HeroiBatalha, o sistema deve criar um chave composta de sendo BatalhaId e HeroiId;
        /// </summary>
        /// <param name="modelBuilder">Objetos criados a partir das classes </param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(
                entity =>
                {   ///Função lambyda
                    entity.HasKey(e => new { e.BatalhaId, e.HeroiId });
                });
        }
    }
}
