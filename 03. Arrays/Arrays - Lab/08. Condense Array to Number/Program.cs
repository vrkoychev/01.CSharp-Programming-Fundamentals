using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int condensed = nums.Length;

            while (condensed > 1)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }

                condensed--;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
