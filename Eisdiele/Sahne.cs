using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal class Sahne : Zutatendecorator
    {
        public Sahne(Eis Eis) : base(Eis) { }

        public override string GetDescription()
        {
            return Eis.GetDescription() + ", Sahne";
        }

        public override double GetPrice()
        {
            return Eis.GetPrice() + 0.40;
        }
    }
}
