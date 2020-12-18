using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Huawei : IMobileShop
    {
        public void ModelNo()
        {
            Console.WriteLine("huawei P40 Pro");
        }

        public void Price()
        {
            Console.WriteLine("1179$\n");
        }
    }
}
