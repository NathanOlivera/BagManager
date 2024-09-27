using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Antidote : item
    {
        public Antidote()
        {
            this.name = "Antidote";
            this.quant = 0;
        }
        public override void Usar(Pokemon pokemon)
        {
            pokemon.hp += 20;
        }
    }
}
