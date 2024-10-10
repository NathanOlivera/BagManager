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
        public override bool Usar(Pokemon pokemon)
        {
            if(pokemon.envenenado == true)
            {
                pokemon.envenenado = false;
                return true;
            } else
            {
                return false;
            }
        }
    }
}
