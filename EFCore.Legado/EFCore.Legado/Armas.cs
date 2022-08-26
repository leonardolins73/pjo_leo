using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class Armas
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int HeroiId { get; set; }
        public int? IdentidadeSecretaId { get; set; }

        public virtual Herois Heroi { get; set; }
        public virtual IdentidadesSecretas IdentidadeSecreta { get; set; }
    }
}
