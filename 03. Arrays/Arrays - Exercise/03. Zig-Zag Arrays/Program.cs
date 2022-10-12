using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 == 0)
                {
                    arr1[i] = numbers[0];
                    arr2[i] = numbers[1];
                }
                else
                {
                    arr2[i] = numbers[0];
                    arr1[i] = numbers[1];
                }
            }

            Console.WriteLine(string.Join(' ', arr1));
            Console.WriteLine(string.Join(' ', arr2));
        }
    }
}
