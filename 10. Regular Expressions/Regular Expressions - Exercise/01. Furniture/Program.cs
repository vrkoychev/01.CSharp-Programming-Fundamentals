using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @">>([A-Za-z]+)<<(\d+[.]\d+|\d+)!(\d{1,})";
            decimal spendMoney = 0;

            List<string> furniture = new List<string>(0);

            while (input != "Purchase")
            {
                bool isMatch = Regex.IsMatch(input, pattern);

                if (isMatch)
                {
                    Match match = Regex.Match(input, pattern);

                    string furnitureName = match.Groups[1].Value;
                    decimal price = decimal.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    furniture.Add(furnitureName);
                    spendMoney += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture: ");
            foreach (string item in furniture)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {spendMoney:F2}");
        }
    }
}
