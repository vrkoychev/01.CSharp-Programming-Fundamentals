using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (string word in input)
            {
                foreach (char ch in word)
                {
                    if (letters.ContainsKey(ch))
                    {
                        letters[ch]++; 
                    }
                    else
                    {
                        letters.Add(ch, 1);
                    }
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
