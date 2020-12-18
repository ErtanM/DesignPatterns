using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Iphone : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("Iphone 12");
        }

        public void Price()
        {
            Console.WriteLine("1200$\n");
        }
    }
}
