using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class Herois
    {
        public Herois()
        {
            Armas = new HashSet<Armas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int? HeroiBatalhaBatalhaId { get; set; }
        public int? HeroiBatalhaHeroiId { get; set; }

        public virtual HeroisBatalhas HeroiBatalha { get; set; }
        public virtual ICollection<Armas> Armas { get; set; }
    }
}
