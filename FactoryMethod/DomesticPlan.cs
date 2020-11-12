using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DomesticPlan : Plan
    {
        public override void GetRate()
        {
            rate = 3.50;
        }
    }
}
