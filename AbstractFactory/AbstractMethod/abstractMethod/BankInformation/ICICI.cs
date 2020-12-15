using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractMethod.BankInformation
{
    public class ICICI : IBank
    {
        private readonly string bankName;

        public ICICI()
        {
            bankName = "ICICI";
        }
        public string getBankName()
        {
            return bankName;
        }
    }
}
