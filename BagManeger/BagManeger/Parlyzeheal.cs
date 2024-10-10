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
        public override bool Usar(Pokemon pokemon)
        {
            if (pokemon.paralisado == true)
            {
                pokemon.paralisado = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
