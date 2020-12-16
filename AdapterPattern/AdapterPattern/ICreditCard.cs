using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface ICreditCard
    {
        public void giveBankDetails();
        public string getGreditCard();
    }
}
