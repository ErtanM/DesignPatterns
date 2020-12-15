using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.BankInformation
{
    public class SBI : IBank
    {
        private readonly string bankName;

        public SBI()
        {
            bankName = "SBI";
        }

        public string getBankName()
        {
            return bankName;
        }
    }
}
