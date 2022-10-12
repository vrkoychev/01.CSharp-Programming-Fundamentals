using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintCharsInRange(a, b);
        }

        private static void PrintCharsInRange(char a, char b)
        {
            int first = (int)a;
            int second = (int)(b);
            int temp = 0;

            if (first > second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            for (int i = first + 1; i < second; i++)
            {
                char print = Convert.ToChar(i);
                Console.Write(print + " ");
            }
        }
    }
}
