using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secondIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                char currCh = (char)i;
                Console.Write($"{currCh} ");
            }
        }
    }
}
