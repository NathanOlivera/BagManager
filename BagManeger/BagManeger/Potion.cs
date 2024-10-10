using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class Potion : item
    {
        static public string audio = "C:\\Users\\GATEWAY\\source\\repos\\BagManeger\\BagManeger\\media\\heal.wav";
        public Potion()
        {
            this.name = "Potion";
            this.quant = 0;
        }
        public override bool Usar(Pokemon pokemon)
        {
            if (pokemon.hp == 0 || pokemon.hp == pokemon.hpmax)
            {
                return false;
            }
            else if (pokemon.hp + 20 <= pokemon.hpmax)
            {
                pokemon.hp += 20;
                return true;
            }
            else {
                pokemon.hp = pokemon.hpmax;
                return true;
            }
        }
    }
}
