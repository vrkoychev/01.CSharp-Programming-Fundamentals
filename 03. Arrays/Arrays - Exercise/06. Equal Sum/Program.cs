using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    rightSum += numbers[k];
                }

                if (leftSum == rightSum)
                {
                    isFound = true;
                    Console.WriteLine(i);
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
