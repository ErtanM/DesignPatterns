using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ChineeseFood : FoodDecorator
    {
        public ChineeseFood(IFood newFood) : base(newFood)
        {

        }
        public override double FoodPrice()
        {
            return base.FoodPrice() + 65.0;
        }

        public override string PrepareFood()
        {
            return base.PrepareFood() + "with fried rice and Manchurian. ";
        }
    }
}
