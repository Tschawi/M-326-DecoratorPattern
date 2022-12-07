using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal class Schokokugel : Zutatendecorator
    {
        public Schokokugel(Eis Eis) : base(Eis) { }

        public override string GetDescription()
        {
            return Eis.GetDescription() + ", Schokokugel";
        }

        public override double GetPrice()
        {
            return Eis.GetPrice() + 0.30;
        }
    }
}
