using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.LoanInformation
{
    public class LoanFactory : AbstractFactory
    {
        public override IBank GetBank(string bank)
        {
            return null;
        }

        public override Loan GetLoan(string loan)
        {
            if (loan.Equals("Home"))
            {
                return new HomeLoan();
            }
            if (loan.Equals("Business"))
            {
                return new BusinessLoan();
            }
            if (loan.Equals("Education"))
            {
                return new EducationLoan();
            }

            return null;
        }
    }
}
