using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
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

            int[] bombAndPower = 
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bomb = bombAndPower[0];
            int power = bombAndPower[1];

            for (int i = 0; i < nums.Count; i++)
            {
                int currNum = nums[i];
                if (currNum == bomb)
                {
                    int left = Math.Max(i - power, 0);

                    int rigth = Math.Min(i + power, nums.Count - 1);

                    int detonation = rigth - left + 1;
                    nums.RemoveRange(left, detonation);
                    i = -1;
                }
            }

            Console.WriteLine(nums.Sum());
        }
    }
}
