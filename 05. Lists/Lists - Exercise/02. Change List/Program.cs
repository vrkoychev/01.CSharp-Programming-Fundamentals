using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split(' ');
                string command = inputs[0];
                int element = int.Parse(inputs[1]);

                if (command == "Delete")
                {
                    nums.RemoveAll(nums => nums == element);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputs[2]);

                    nums.Insert(index, element);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
