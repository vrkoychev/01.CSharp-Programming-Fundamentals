using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            MinValueOfThreeNumbers(a, b, c);
        }

        private static void MinValueOfThreeNumbers(int a, int b, int c)
        {
            int minValue = a;
            if (a <= b && a <= c)
                minValue = a;
            if (b <= a && b <= c)
                minValue = b;
            if (c <= a && c <= b)
                minValue = c;

            Console.WriteLine(minValue);
        }
    }
}
