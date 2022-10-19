using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = 
                Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split(' ');

                if (inputs.Length == 2)
                {
                    string command = inputs[0];
                    int passengers = int.Parse(inputs[1]);

                    wagons.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(inputs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currNum = wagons[i];

                        if ((currNum + passengers) <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
