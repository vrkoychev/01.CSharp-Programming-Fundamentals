using System;
using System.Linq;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal totalSum = 0;

            foreach (string word in words)
            {
                decimal sum = 0;

                char firstLetter = word[0];
                int num = int.Parse(word.Substring(1, word.Length - 2));
                char lastLetter = word[word.Length - 1];

                if (Char.IsUpper(firstLetter))
                {
                    int firstLetterPosition = (int)firstLetter - 64;

                    sum = (decimal)num / firstLetterPosition;
                }
                else if (Char.IsLower(firstLetter))
                {
                    int firstLetterPosition = (int)firstLetter - 96;

                    sum = (decimal)num * firstLetterPosition;
                }

                if (Char.IsUpper(lastLetter))
                {
                    int lastLetterPosition = (int)lastLetter - 64;
                    sum -= lastLetterPosition;
                }
                else if (Char.IsLower(lastLetter))
                {
                    int lastLetterPosition = (int)lastLetter - 96;
                    sum += lastLetterPosition;
                }

                totalSum += sum;
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
