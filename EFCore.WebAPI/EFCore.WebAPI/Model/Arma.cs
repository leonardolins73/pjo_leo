using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Model
{
    public class Arma
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public Heroi Herois { get; set; }
        public int HeroiId { get; set; }
    }
}
