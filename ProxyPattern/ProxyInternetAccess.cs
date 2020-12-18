using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ProxyInternetAccess : IOfficeInternetAccess
    {
        public string employeeName;

        public RealInternetAccess realAccess;

        public ProxyInternetAccess(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public void GrantInternetAccess()
        {
            if (getRole(employeeName) > 4)
            {
                realAccess = new RealInternetAccess(employeeName);
                realAccess.GrantInternetAccess();
            }
            else
            {
                Console.WriteLine("No internet access granted. Your job level is blow 5.");
            }
        }


        public int getRole(string employeeName)
        {
            return 5;
        }
    }
}
