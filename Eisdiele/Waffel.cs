using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal class Waffel : Eis
    {
        public Waffel()
        {
            Description = "Waffel";
        }

        public override double GetPrice()
        {
            return 2.05;
        }
    }
}
