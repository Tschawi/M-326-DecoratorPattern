using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eisdiele
{
    internal abstract class Eis
    {
        public string Description { get; set; } = "Unknown";

        virtual public string GetDescription()
        {
            return Description;
        }

        public abstract double GetPrice();
    }
}
