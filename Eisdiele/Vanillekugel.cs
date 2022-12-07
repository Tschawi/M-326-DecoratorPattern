using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal class Vanillekugel : Zutatendecorator
    {
        public Vanillekugel(Eis Eis) : base(Eis) { }

        public override string GetDescription()
        {
            return Eis.GetDescription() + ", Vanillekugel";
        }

        public override double GetPrice()
        {
            return Eis.GetPrice() + 0.30;
        }
    }
}
