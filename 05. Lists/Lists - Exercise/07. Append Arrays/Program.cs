using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays =
                Console.ReadLine()
                .Split('|')
                .ToList();

            List<int> result = new List<int>();

            for (int i = arrays.Count - 1; i >= 0; i--)
            {
                result.AddRange(arrays[i].Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
