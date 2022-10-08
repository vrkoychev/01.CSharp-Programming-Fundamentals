using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            PriceForProduct(product, quantity);
        }

        private static void PriceForProduct(string product, double quantity)
        {
            double sum = 0;

            if (product == "coffee")
            {
                sum = quantity * 1.50;
            }
            else if (product == "water")
            {
                sum = quantity * 1.00;
            }
            else if (product == "coke")
            {
                sum = quantity * 1.40;
            }
            else if (product == "water")
            {
                sum = quantity * 2.00;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
