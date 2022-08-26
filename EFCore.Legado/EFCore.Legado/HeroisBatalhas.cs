using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class HeroisBatalhas
    {
        public HeroisBatalhas()
        {
            Batalhas = new HashSet<Batalhas>();
            Herois = new HashSet<Herois>();
        }

        public int HeroiId { get; set; }
        public int BatalhaId { get; set; }
        public int? IdentidadeSecretaId { get; set; }

        public virtual IdentidadesSecretas IdentidadeSecreta { get; set; }
        public virtual ICollection<Batalhas> Batalhas { get; set; }
        public virtual ICollection<Herois> Herois { get; set; }
    }
}
