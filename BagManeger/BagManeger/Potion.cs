using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Potion : item
    {
        public Potion()
        {
            this.name = "Potion";
            this.quant = 0;
        }
        public override void Usar(Pokemon pokemon)
        {
            pokemon.hp += 20;
        }
    }
}
