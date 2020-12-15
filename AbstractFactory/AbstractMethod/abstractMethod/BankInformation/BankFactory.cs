using abstractMethod.LoanInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.BankInformation
{
    public class BankFactory : AbstractFactory
    {
        public override IBank GetBank(string bank)
        {
            if (bank == null)
            {
                return null;
            }

            if (bank.Equals("HDFC"))
            {
                return new HDFC();
            }

            if (bank.Equals("ICICI"))
            {
                return new ICICI();
            }

            if (bank.Equals("SBI"))
            {
                return new SBI();
            }


            return null;
        }

        public override Loan GetLoan(string loan)
        {
            return null;
        }
    }
}
