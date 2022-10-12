using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int quantity = int.Parse(Console.ReadLine());

                sum += quantity;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantity;
                }

                n--;
            }

            Console.WriteLine(sum);


        }
    }
}
