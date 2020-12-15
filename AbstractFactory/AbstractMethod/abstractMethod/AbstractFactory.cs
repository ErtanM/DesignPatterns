using abstractMethod.LoanInformation;
using abstractMethod.BankInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod
{
    public abstract class AbstractFactory
    {
        public abstract IBank GetBank(string bank);

        public abstract Loan GetLoan(string loan);

    }
}
