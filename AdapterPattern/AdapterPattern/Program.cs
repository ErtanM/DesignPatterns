using System;

namespace AdapterPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditCard targetInterface = new BankCustomer();
            targetInterface.giveBankDetails();
            Console.WriteLine(targetInterface.getGreditCard());

            Console.ReadLine();
        }
    }
}
