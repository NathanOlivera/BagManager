using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Parlyzeheal : item
    {
        public Parlyzeheal()
        {
            this.name = "Parlyze Heal";
            this.quant = 0;
        }
        public override void Usar(Pokemon pokemon)
        {
            pokemon.hp += 20;
        }
    }
}
