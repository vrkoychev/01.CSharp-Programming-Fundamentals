using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums1 =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> nums2 =
                Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < Math.Min(nums1.Count, nums2.Count); i++)
            {
                result.Add(nums1[i]);
                result.Add(nums2[i]);
            }

            if (nums1.Count > nums2.Count)
            {
                for (int i = nums2.Count; i < nums1.Count; i++)
                {
                    result.Add(nums1[i]);
                }
            }
            else if (nums2.Count > nums1.Count)
            {
                for (int i = nums1.Count; i < nums2.Count; i++)
                {
                    result.Add(nums2[i]);
                }
            }

            Console.WriteLine(string.Join(' ', result));
        }
    }
}
