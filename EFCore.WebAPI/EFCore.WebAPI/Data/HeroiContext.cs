using EFCore.WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext: DbContext
    {
        public DbSet<Heroi> Herois { get; set; }

        public DbSet<Batalha> Batalhas { get; set; }

        public DbSet<Arma> Armas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=estudos_leo;Persist Security Info=True;User ID=estudos_leo;Initial Catalog=estudos;Data Source=DESKTOP-I1223JC\SQLEXPRESS");
        }
    }
}
