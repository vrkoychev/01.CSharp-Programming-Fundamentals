using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool isChecked = false;

            while (input != "end")
            {
                string[] inputs = input.Split();

                string command = inputs[0];

                if (command == "Add")
                {
                    isChecked = true;
                    int number = int.Parse(inputs[1]);
                    nums.Add(number);
                }
                else if (command == "Remove")
                {
                    isChecked = true;
                    int number = int.Parse(inputs[1]);
                    nums.Remove(number);
                }
                else if (command == "RemoveAt")
                {
                    isChecked = true;
                    int number = int.Parse(inputs[1]);
                    nums.RemoveAt(number);
                }
                else if (command == "Insert")
                {
                    isChecked = true;
                    int number = int.Parse(inputs[1]);
                    int index = int.Parse(inputs[2]);
                    nums.Insert(index, number);
                }
                else if (command == "Contains")
                {
                    int number = int.Parse(inputs[1]);
                    bool isContaining = false;

                    for (int i = 0; i < nums.Count; i++)
                    {
                        int currNum = nums[i];

                        if (nums[i] == number)
                        {
                            Console.WriteLine("Yes");
                            isContaining = true;
                            break;
                        }
                    }

                    if (!isContaining)
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (command == "PrintEven")
                {
                    List<int> evenNumbers = new List<int>();

                    for (int i = 0; i < nums.Count; i++)
                    {
                        int currNum = nums[i];

                        if (currNum % 2 == 0)
                        {
                            evenNumbers.Add(currNum);
                        }
                    }

                    Console.WriteLine(string.Join(' ', evenNumbers));
                }
                else if (command == "PrintOdd")
                {
                    List<int> oddNumbers = new List<int>();

                    for (int i = 0; i < nums.Count; i++)
                    {
                        int currNum = nums[i];

                        if (currNum % 2 != 0)
                        {
                            oddNumbers.Add(currNum);
                        }
                    }

                    Console.WriteLine(string.Join(' ', oddNumbers));
                }
                else if (command == "GetSum")
                {
                    int sum = 0;

                    for (int i = 0; i < nums.Count; i++)
                    {
                        int currSum = nums[i];
                        sum += currSum;
                    }

                    Console.WriteLine(sum);
                }
                else if (command == "Filter")
                {
                    string condition = inputs[1];
                    int number = int.Parse(inputs[2]);

                    if (condition == "<")
                    {
                        List<int> first = new List<int>();

                        for (int i = 0; i < nums.Count; i++)
                        {
                            int currNum = nums[i];

                            if (currNum < number)
                            {
                                first.Add(currNum);
                            }
                        }

                        Console.WriteLine(string.Join(' ', first));
                    }
                    else if (condition == ">")
                    {
                        List<int> second = new List<int>();

                        for (int i = 0; i < nums.Count; i++)
                        {
                            int currNum = nums[i];

                            if (currNum > number)
                            {
                                second.Add(currNum);
                            }
                        }

                        Console.WriteLine(string.Join(' ', second));
                    }
                    else if (condition == ">=")
                    {
                        List<int> third = new List<int>();

                        for (int i = 0; i < nums.Count; i++)
                        {
                            int currNum = nums[i];

                            if (currNum >= number)
                            {
                                third.Add(currNum);
                            }
                        }

                        Console.WriteLine(string.Join(' ', third));
                    }
                    else if (condition == "<=")
                    {
                        List<int> fourth = new List<int>();

                        for (int i = 0; i < nums.Count; i++)
                        {
                            int currNum = nums[i];

                            if (currNum <= number)
                            {
                                fourth.Add(currNum);
                            }
                        }

                        Console.WriteLine(string.Join(' ', fourth));
                    }
                }

                input = Console.ReadLine();
            }

            if (isChecked)
            {
                Console.WriteLine(string.Join(' ', nums));
            }
        }
    }
}
