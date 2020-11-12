using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class GetPlanFactory
    {
        /// <summary>
        /// To check if user entered one of these.
        /// </summary>
        /// <param name="planType"></param>
        /// <returns></returns>
        public Plan GetPlan(string planType)
        {
            if (planType == null)
            {
                return null;
            }

            if (planType == "DOMESTICPLAN")
            {
                return new DomesticPlan();
            }
            else if (planType == "COMMERCIALPLAN")
            {
                return new CommertialPlan();
            }
            else if(planType == "INSTUTIONALPLAN")
            {
                return new InstitutionalPlan();
            }

            return null;
        }
    }
}
