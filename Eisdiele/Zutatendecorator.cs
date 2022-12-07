using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal abstract class Zutatendecorator : Eis
    {
        protected Eis Eis;
        public Zutatendecorator(Eis Eis)
        {
            this.Eis = Eis;
        }

        public override abstract string GetDescription();
    }
}
