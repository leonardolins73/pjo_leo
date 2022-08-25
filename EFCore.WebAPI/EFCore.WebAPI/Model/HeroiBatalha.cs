using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Model
{
    public class HeroiBatalha
    {
        private List<Batalha> batalhas;

        public int HeroiId { get; set; }

        public List<Heroi> Herois { get; set; }

        public int BatalhaId { get; set; }

        public List<Batalha> Batalhas { get; set; }

    }
}
