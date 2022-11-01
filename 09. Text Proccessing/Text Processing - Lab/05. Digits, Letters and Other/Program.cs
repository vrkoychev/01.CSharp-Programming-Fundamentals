using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            List<char> letters = new List<char>();
            List<char> digits = new List<char>();
            List<char> symbols = new List<char>();

            foreach (char ch in text)
            {
                if (char.IsLetter(ch))
                {
                    letters.Add(ch);
                }
                else if (char.IsDigit(ch))
                {
                    digits.Add(ch);
                }
                else
                {
                    symbols.Add(ch);
                }
            }

            foreach (char ch in digits)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            foreach (char ch in letters)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
            foreach (char ch in symbols)
            {
                Console.Write(ch);
            }
        }
    }
}
