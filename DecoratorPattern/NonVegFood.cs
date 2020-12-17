using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class NonVegFood : FoodDecorator
    {
        /// <summary>
        /// base() is the super(newfood) version 
        /// </summary>
        /// <param name="newFood"></param>
        public NonVegFood(IFood newFood) : base(newFood)
        {
            
        }

        #region IFood Implementation
        public override  double FoodPrice()
        {
            return base.FoodPrice() + 150.0;
        }

        public override  string PrepareFood()
        {
            return base.PrepareFood() + "with roasted chiken and chiken curry. ";
        }

        #endregion
    }
}
