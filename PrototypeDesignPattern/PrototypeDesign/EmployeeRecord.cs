using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesign
{
    public class EmployeeRecord : IPrototype
    {
        private readonly int id;
        private readonly string name, designation;
        private readonly double salary;
        private readonly string address;

        public EmployeeRecord()
        {
            Console.WriteLine("    Employee Records of Oracle Corporation");
            Console.WriteLine("-".PadRight(10));
            Console.WriteLine($"{id} {name} {designation} {salary} {address}");
        }

        public EmployeeRecord(int id, string name, string designation, string address, double salary) : base()
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.designation = designation;
            this.salary = salary;
        }

        public void ShowRecord()
        {
            string pad = "-";
            Console.WriteLine("Employee records of Oracle Corp.");
            Console.WriteLine(pad.PadRight(10));
            Console.WriteLine($"Eid {name} {designation} {salary} {address} \n");
        }

        public IPrototype GetClone()
        {
            return new EmployeeRecord(id, name, designation, address, salary);
        }

    }
}
