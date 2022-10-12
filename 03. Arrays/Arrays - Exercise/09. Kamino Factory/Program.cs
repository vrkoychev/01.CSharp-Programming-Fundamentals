using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];
            string command = Console.ReadLine();

            int tempCount = 1;
            int maxCount = 1;

            while (command != "Clone them!")
            {
                arr = command.Split("!",StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == arr[i + 1] && arr[i] == 1)
                    {
                        tempCount++;
                    }
                    else
                        tempCount = 1;

                    tempCount = maxCount;

                    tempCount = 1;
                }
            }

        }
    }
}
