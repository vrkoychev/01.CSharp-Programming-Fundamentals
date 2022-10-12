﻿using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int index = int.Parse(Console.ReadLine());

            if (index < 1 || index > 7)
                Console.WriteLine("Invalid day!");
            else
                Console.WriteLine(days[index - 1]);
        }
    }
}
