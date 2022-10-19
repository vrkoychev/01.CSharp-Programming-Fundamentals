using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = 
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                int currNum = nums[i];

                if (currNum < 0)
                {
                    nums.RemoveAt(i);
                    i = -1;
                }
            }

            nums.Reverse();

            if (nums.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', nums));
            }
        }
    }
}
