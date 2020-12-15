using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public  abstract class Company : CD
    {
        public override int Price()
        {
            return 1;
        }
    }
}
