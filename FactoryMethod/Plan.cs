using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FactoryMethod
{
    abstract class Plan
    {
        protected double rate;

        public abstract void GetRate();

        /// <summary>
        /// Will calculate bill rate respective to users input. 
        /// </summary>
        /// <param name="units"></param>
        public void calculateBill(int units)
        {
            WriteLine($"Units*rate: {units*rate}");
        }

    }
}
