using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.BankInformation
{
    public class HDFC : IBank
    {
        private readonly string bankName;

        public HDFC()
        {
            bankName = "HDFC BANK";
        }

        /// <summary>
        /// Implementation of Interface IBank
        /// </summary>
        /// <returns></returns>
        public string getBankName()
        {
            return bankName;
        }
    }
}
