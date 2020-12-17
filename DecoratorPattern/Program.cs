using System;

namespace DecoratorPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("======== Food Menu ========\n");
                Console.WriteLine("1. Vegetarian Food\n");
                Console.WriteLine("2. Non-Vegetarian Food\n");
                Console.WriteLine("3. Chineese Food\n");
                Console.WriteLine("4. Exit\n");
                Console.Write("Enter your choise: ");

                int.TryParse(Console.ReadLine(), out input);

                switch (input)
                {
                    case 1:
                        VegFood vf = new VegFood();
                        Console.WriteLine(vf.PrepareFood());
                        Console.WriteLine(vf.FoodPrice());
                        break;

                    case 2:
                        IFood f1 = new NonVegFood((IFood)new VegFood());
                        Console.WriteLine(f1.PrepareFood());
                        Console.WriteLine(f1.FoodPrice());
                        break;
                    case 3:
                        IFood f2 = new ChineeseFood((IFood)new VegFood());
                        Console.WriteLine(f2.PrepareFood());
                        Console.WriteLine(f2.FoodPrice());
                        break;

                    default:
                        Console.WriteLine("Other than these no food available.");
                        break;
                }

            } while (input != 4);

        }
    }
}
