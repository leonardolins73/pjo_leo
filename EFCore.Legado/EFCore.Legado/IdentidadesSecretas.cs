using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class IdentidadesSecretas
    {
        public IdentidadesSecretas()
        {
            Armas = new HashSet<Armas>();
            HeroisBatalhas = new HashSet<HeroisBatalhas>();
            InverseIdentidade = new HashSet<IdentidadesSecretas>();
        }

        public int Id { get; set; }
        public string NomeReal { get; set; }
        public int? IdentidadeId { get; set; }

        public virtual IdentidadesSecretas Identidade { get; set; }
        public virtual ICollection<Armas> Armas { get; set; }
        public virtual ICollection<HeroisBatalhas> HeroisBatalhas { get; set; }
        public virtual ICollection<IdentidadesSecretas> InverseIdentidade { get; set; }
    }
}
