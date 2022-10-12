using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double sum = 0;

            while (command != "Start")
            {
                double coin = double.Parse(command);

                if (coin == 0.1 || coin == 0.2 || coin == 0.5
                    || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                    Console.WriteLine($"Cannot accept {coin}");

                command = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts" && sum >= 2.0)
                {
                    sum -= 2.0;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (product == "Nuts" && sum < 2.0)
                    Console.WriteLine("Sorry, not enough money");
                else if (product == "Water" && sum >= 0.7)
                {
                    sum -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (product == "Water" && sum < 0.7)
                    Console.WriteLine("Sorry, not enough money");
                else if (product == "Crisps" && sum >= 1.5)
                {
                    sum -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (product == "Crisps" && sum < 1.5)
                    Console.WriteLine("Sorry, not enough money");
                else if (product == "Soda" && sum >= 0.8)
                {
                    sum -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else if (product == "Soda" && sum < 0.8)
                    Console.WriteLine("Sorry, not enough money");
                else if (product == "Coke" && sum >= 1.0)
                {
                    sum -= 1.0;
                    Console.WriteLine($"Purchased coke");
                }
                else if (product == "Coke" && sum < 1.0)
                    Console.WriteLine("Sorry, not enough money");
                else
                    Console.WriteLine("Invalid product");

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
