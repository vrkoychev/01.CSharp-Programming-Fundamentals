using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split();

                string command = inputs[0];

                int number = int.Parse(inputs[1]);

                if (command == "Add")
                { 
                    nums.Add(number);
                }
                else if (command == "Remove")
                {
                    nums.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    nums.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputs[2]);
                    nums.Insert(index, number);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
