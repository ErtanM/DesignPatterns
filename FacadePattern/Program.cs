using System;

namespace FacadePattern
{
   public class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            ShopKeeper sk = new ShopKeeper();

            do
            {
                Console.WriteLine("======== Mobile Shop ========");
                Console.WriteLine("1. Apple");
                Console.WriteLine("2. Samsung");
                Console.WriteLine("3. Huawei");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choise: ");

                int.TryParse(Console.ReadLine().Trim(), out input);

                switch (input)
                {
                    case 1: sk.IphoneSale(); break;
                    case 2: sk.SamsungSale(); break;
                    case 3: sk.HuaweiSale(); break;
                };

            } while (input != 4);
        }
    }
}
