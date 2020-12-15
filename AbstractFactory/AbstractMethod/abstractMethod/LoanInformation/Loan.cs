using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.LoanInformation
{
    public abstract class Loan
    {
        protected double rate;

        public abstract void GetInterestRate(double rate);

        public void CalculateLoanPayment(double loanAmount, int years)
        {
            double EMI;
            int n;

            n = years * 12;
            rate = rate / 1200;
            EMI = ((rate * Math.Pow((1 + rate), n)) / ((Math.Pow((1 + rate), n)) - 1)) * loanAmount;

            Console.WriteLine($"your's monthly EMI is {EMI} for the amount {loanAmount} you have borrowed");
        }
    }
}
