using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int tempCount = 1;
            int maxCount = 1;
            int number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                    tempCount++;
                else
                    tempCount = 1;

                if (tempCount > maxCount)
                {
                    maxCount = tempCount;
                    number = numbers[i];
                }
            }

            int[] array = new int[maxCount];

            for (int i = 0; i < maxCount; i++)
            {
                array[i] = number;
            }

            Console.WriteLine(string.Join(' ', array));
        }
    }
}
