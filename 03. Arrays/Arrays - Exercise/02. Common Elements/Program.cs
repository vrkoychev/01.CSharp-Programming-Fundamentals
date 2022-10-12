using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split().
                ToArray();

            string[] arr2 = Console.ReadLine()
                .Split().
                ToArray();

            string[] newArr = new string[arr1.Length];

            for (int j = 0; j < arr2.Length; j++)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr2[j] == arr1[i])
                        Console.Write($"{arr2[j]}" + ' ');
                }
            }
        }

    }
}
