using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double sum = 0;

            while (orders > 0)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);

                sum += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
                orderPrice = 0;
                orders--;
            }

            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
