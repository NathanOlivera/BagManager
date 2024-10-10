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
        public override bool Usar(Pokemon pokemon)
        {
            if (pokemon.hp == 0 || pokemon.hp == pokemon.hpmax)
            {
                return false;
            }
            else if (pokemon.hp + 50 <= pokemon.hpmax)
            {
                pokemon.hp += 50;
                return true;
            }
            else
            {
                pokemon.hp = pokemon.hpmax;
                return true;
            }
        }
    }
}
