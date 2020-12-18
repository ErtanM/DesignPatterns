using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealInternetAccess : IOfficeInternetAccess
    {
        public string employeeName;

        public RealInternetAccess(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public void GrantInternetAccess()
        {
            Console.WriteLine($"\n Internet Access granted for employee: {employeeName}");
        }
    }
}
