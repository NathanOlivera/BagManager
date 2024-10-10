using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Revive : item
    {
        public Revive()
        {
            this.name = "Revive";
            this.quant = 0;
        }
        public override bool Usar(Pokemon pokemon)
        {
            if(pokemon.hp == 0)
            {
                pokemon.hp = pokemon.hpmax/2;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
