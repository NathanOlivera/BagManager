using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal abstract class item 
    {
        public string name;
        public int quant;

        public item DeepCopy()
        {
            item othercopy = (item)this.MemberwiseClone();
            return othercopy;
        }
        public abstract void Usar(Pokemon pokemon);

        public override string ToString()
        {
            return $"{name} Quantidade: {quant}";

        }
    }
}
