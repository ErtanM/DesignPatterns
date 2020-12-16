using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class BankCustomer : BankDetails, ICreditCard
    {
        /// <summary>
        /// default constructor
        /// </summary>
        public BankCustomer()
        {

        }

        public string getGreditCard()
        {
            return $"The Account number: {accNumber} of {accHolderName} in {bankName} bank is valid and authenticated for issuing the credit card";
        }

        public void giveBankDetails()
        {
            try
            {
                Console.Write("Enter the Account Holder Name: ");
                accHolderName = Console.ReadLine();

                Console.Write("Enter the Account Number: ");
                accNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter the Bank Name: ");
                bankName = Console.ReadLine();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
