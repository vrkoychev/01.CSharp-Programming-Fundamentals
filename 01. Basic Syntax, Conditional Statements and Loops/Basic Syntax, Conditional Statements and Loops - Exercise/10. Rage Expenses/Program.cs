﻿using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsets = gamesLost / 2;
            int mouses = gamesLost / 3;
            int keyboards = gamesLost / 6;
            int displays = gamesLost / 12;

            double rageExpenses = headsets * headsetPrice + mouses * mousePrice + keyboards * keyboardPrice + displays * displayPrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
