using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagManeger
{
    internal class item
    {
        public string name = "a";
        public int quant = 1;

        public override string ToString()
        {
            return $"{name} Quantidade: {quant}";

        }
    }
}
