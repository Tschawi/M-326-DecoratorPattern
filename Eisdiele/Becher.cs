using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal class Becher : Eis
    {
        public Becher()
        {
            Description = "Becher";
        }

        public override double GetPrice()
        {
            return 2.00;
        }
    }
}
