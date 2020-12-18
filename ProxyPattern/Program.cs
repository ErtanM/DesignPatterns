using System;

namespace ProxyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOfficeInternetAccess access = new ProxyInternetAccess("Ertan Mutlu");

            access.GrantInternetAccess();
        }
    }
}
