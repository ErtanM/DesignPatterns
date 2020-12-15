using abstractMethod.BankInformation;
using abstractMethod.LoanInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod
{
    public class FactoryCreator
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Equals("Bank"))
            {
                return new BankFactory();
            }
            else if (choice.Equals("Loan"))
            {
                return new LoanFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
