using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPlanFactory planFactory = new GetPlanFactory();

            string billName;

            int unitNumber = 0;

            Console.WriteLine("Enter bill name: ");

            billName = Console.ReadLine().ToUpper();

            Console.WriteLine("Enter the number of units for bill: ");

            unitNumber = int.Parse(Console.ReadLine());

            var p = planFactory.GetPlan(planType:billName);

            Console.WriteLine($"Bill amount for {billName} of {unitNumber} unit is : ");
            p.GetRate();
            p.calculateBill(unitNumber);

            Console.ReadKey();
        }
    }
}
