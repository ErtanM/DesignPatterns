using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class InstitutionalPlan : Plan
    {
        
        public override void GetRate()
        {
            rate = 5.50;
        }
    }
}
