using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while (input != "End")
            {
                string[] inputs = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = inputs[0];

                if (command == "Add")
                {
                    int number = int.Parse(inputs[1]);

                    nums.Add(number);
                }
                else if (command == "Insert")
                {
                    int number = int.Parse(inputs[1]);
                    int index = int.Parse(inputs[2]);

                    if (index > nums.Count + 1)
                    {
                        Console.WriteLine("Invalid index");
                        break;
                    }
                    else
                    {
                        nums.Insert(index, number);
                    }
                }
                else if (command == "Remove")
                {
                    int index = int.Parse(inputs[1]);

                    if (index > nums.Count + 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (command == "Shift")
                {
                    int count = int.Parse(inputs[2]);
                    string leftOrRight = inputs[1];

                    if (leftOrRight == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNumber = nums[0];
                            nums.RemoveAt(0);
                            nums.Add(firstNumber);
                        }
                    }
                    else if (leftOrRight == "right")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNumber = nums[nums.Count - 1];
                            nums.RemoveAt(nums.Count - 1);
                            nums.Insert(0, lastNumber);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', nums));
        }
    }
}
