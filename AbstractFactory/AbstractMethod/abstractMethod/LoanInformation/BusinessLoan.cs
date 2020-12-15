using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.LoanInformation
{
    public class BusinessLoan : Loan
    {
        public override void GetInterestRate(double r)
        {
            rate = r;
        }
    }
}
