using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Superpotion : item
    {
        public Superpotion()
        {
            this.name = "Superpotion";
            this.quant = 0;
        }
        public override void Usar(Pokemon pokemon)
        {
            pokemon.hp += 50;
        }
    }
}
