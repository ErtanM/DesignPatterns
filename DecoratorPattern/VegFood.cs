using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class VegFood : IFood
    {

        #region IFood Implementation
        public double FoodPrice()
        {
            return 50.0;
        }

        public string PrepareFood()
        {
            return "Veg Food";
        }

        #endregion
    }
}
