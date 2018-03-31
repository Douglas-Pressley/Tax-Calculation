using System;

namespace TaxCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = 79.95;
            double tax1 = 0.06;
            int tax2 = 6;
            Console.WriteLine("The price of the item including tax is " + Tax(price, tax1));
            Console.WriteLine("Please pay " + Tax(price, tax2));
        }
        public static string Tax(double x, double y)
        {
            return (x + (x * y)).ToString("C");
        }
        public static string Tax(double x, int y)
        {
            return (x + (x * y / 100)).ToString("C");
        }
    }
}