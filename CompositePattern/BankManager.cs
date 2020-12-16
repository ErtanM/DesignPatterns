using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class BankManager : IEmployee
    {
        public int id;
        public string name;
        public double salary;

        public BankManager(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        List<IEmployee> employees = new List<IEmployee>();
        public void Add(IEmployee employee)
        {
            employees.Add(employee);
        }

        public IEmployee GetChild(int i)
        {
            return employees[i];
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void Print()
        {
            Console.WriteLine("".PadRight(20, '='));
            Console.WriteLine("ID" + GetId());
            Console.WriteLine("Name" + GetName());
            Console.WriteLine("Salary" + GetSalary());
            Console.WriteLine("".PadRight(20, '='));

            var iterator = employees.GetEnumerator();


            //no need to create employee employee = it.next() here like java
            while (iterator.MoveNext())
            {
                iterator.Current.Print();
                iterator.MoveNext();
            }

        }

        public void Remove(IEmployee employee)
        {
            employees.Remove(employee);
        }
    }
}
