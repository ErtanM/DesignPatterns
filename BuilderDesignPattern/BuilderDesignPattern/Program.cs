using System;

namespace BuilderDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            CDBuilder cDBuilder = new CDBuilder();
            CDType cdType = cDBuilder.BuildSonyCDType();
            cdType.ShowItems();

            CDType cdType2 = cDBuilder.BuildSamsungCDType();
            cdType2.ShowItems();

            Console.ReadLine();
        }
    }
}
