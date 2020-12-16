using System;

namespace CompositePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Cashier(101, "Sohan Kumar", 20000.0);
            IEmployee emp2 = new Cashier(102, "Mohan Kumar", 25000.0);
            IEmployee emp3 = new Accountant(103, "Seema Mahiwal", 30000.0);
            IEmployee manager1 = new BankManager(100, "Ashwani Rajput", 100000.0);

            manager1.Add(emp1);
            manager1.Add(emp2);
            manager1.Add(emp3);

            manager1.Print();

            Console.ReadLine();

        }
    }
}
