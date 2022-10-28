using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double[]> products = new Dictionary<string, double[]>();

            while (input != "buy")
            {
                string[] inputs = input.Split();

                string name = inputs[0];
                double priceForOne = double.Parse(inputs[1]);
                double quantity = double.Parse(inputs[2]);

                double[] prices = new double[2];

                if (products.ContainsKey(name))
                {
                    foreach (var kvp in products)
                    {
                        if (kvp.Key == name)
                        {
                            kvp.Value[0] = priceForOne;
                            kvp.Value[1] += quantity; 
                        }
                    }
                }
                else
                {
                    prices[0] = priceForOne;
                    prices[1] = quantity;
                    products.Add(name, prices);
                }

                input = Console.ReadLine();
            }

            Dictionary<string, double> productsPrice = new Dictionary<string, double>();

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                productsPrice.Add(item.Key, totalPrice);
            }

            foreach (var pr in productsPrice)
            {
                Console.WriteLine($"{pr.Key} -> {pr.Value:F2}");
            }
        }
    }
}
