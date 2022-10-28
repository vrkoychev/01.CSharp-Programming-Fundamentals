using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            List<string> words = new List<string>();

            foreach (string word in input)
            {
                int count = 0;

                foreach (char ch in word)
                {
                    count++;
                }

                if (count % 2 == 0)
                    words.Add(word);
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
