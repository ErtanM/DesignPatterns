using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class FoodDecorator : IFood
    {
        public IFood newFood;

        public FoodDecorator(IFood newFood)
        {
            this.newFood = newFood;
        }

        #region IFood Implementation
        /// <summary>
        /// Put virtual to both of them otherwise we cannot override it in nonvegfood
        /// </summary>
        /// <returns></returns>
        public virtual double FoodPrice()
        {
            return newFood.FoodPrice();
        }

        public virtual string PrepareFood()
        {
            return newFood.PrepareFood();
        }

        #endregion
    }
}
