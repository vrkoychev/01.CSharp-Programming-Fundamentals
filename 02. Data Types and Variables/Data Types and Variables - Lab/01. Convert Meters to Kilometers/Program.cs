﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double metersInKm = meters / 1000.00;

            Console.WriteLine($"{metersInKm:F2}");
        }
    }
}
