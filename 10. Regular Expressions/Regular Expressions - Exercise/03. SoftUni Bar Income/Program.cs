using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%([A-Z][a-z]+)\%[^|$%.]*\<(\w+)\>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+.\d*)\$";

            string input = Console.ReadLine();

            decimal income = 0;

            while (input != "end of shift")
            {
                bool isMatch = Regex.IsMatch(input, pattern);

                if (isMatch)
                {
                    Match order = Regex.Match(input, pattern);

                    string customerName = order.Groups[1].Value;
                    string product = order.Groups[2].Value;
                    int count = int.Parse(order.Groups[3].Value);
                    decimal price = decimal.Parse(order.Groups[4].Value);

                    decimal totalPrice = count * price;
                    income += totalPrice;

                    Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
