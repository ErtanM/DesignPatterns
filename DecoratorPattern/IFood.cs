using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public interface IFood
    {
        string PrepareFood();
        double FoodPrice();
    }
}
