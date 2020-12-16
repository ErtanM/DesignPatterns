using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Cashier : IEmployee
    {

        public int id;
        public string name;
        public double salary;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="salary"></param>
        public Cashier(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }


        #region IEmployee Implementation

        /// <summary>
        /// Empty
        /// </summary>
        /// <param name="employee"></param>
        public void Add(IEmployee employee)
        {
            throw new NotImplementedException();
        }

        public IEmployee GetChild(int i)
        {
            return null;
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
            Console.WriteLine("ID: " + GetId());
            Console.WriteLine("Name: " + GetName());
            Console.WriteLine("Salary: " + GetSalary());
            Console.WriteLine("".PadRight(20, '='));
        }

        /// <summary>
        /// Empty
        /// </summary>
        /// <param name="employee"></param>
        public void Remove(IEmployee employee)
        {
            
        }

        #endregion
    }
}
