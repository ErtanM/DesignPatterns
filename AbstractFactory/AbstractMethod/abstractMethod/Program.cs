using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using abstractMethod.BankInformation;
using abstractMethod.LoanInformation;

namespace abstractMethod
{
    //class that implements Bank interface for step 2.

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of Bank from where you want to take loan amount: ");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter the type of loan you want to take, like home loan,business or educational: ");
            string loanName = Console.ReadLine();

            //Both Factories impelemented here.
            AbstractFactory bankFactory = FactoryCreator.GetFactory("Bank");
            AbstractFactory loanFactory = FactoryCreator.GetFactory("Loan");
            IBank bank = bankFactory.GetBank(bankName);

            Console.WriteLine($"Enter the interest rate for {bank.getBankName()}: ");
            double.TryParse(Console.ReadLine(), out double rate);

            Console.WriteLine("Enter loan amount you want to take: ");
            double.TryParse(Console.ReadLine(), out double loanAmount);

            Console.WriteLine("Enter the number of years to pay your entire loan amount: ");
            int.TryParse(Console.ReadLine(), out int years);

            Console.WriteLine($"You are taking the loan from {bank.getBankName()}");

            Loan loan = loanFactory.GetLoan(loanName);

            loan.GetInterestRate(rate);
            loan.CalculateLoanPayment(loanAmount, years);

            Console.ReadLine();
        }
    }
}
