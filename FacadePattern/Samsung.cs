using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Samsung : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Samsung Galaxy S20 FE");
        }

        public void Price()
        {
            Console.WriteLine("1100$\n");
        }
    }
}
