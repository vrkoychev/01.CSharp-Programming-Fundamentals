using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            FactorialDivision(a, b);
        }

        private static void FactorialDivision(int a, int b)
        {
            double factorialOfA = 1;
            double factorialOfB = 1;

            for (int i = a; i > 0; i--)
            {
                factorialOfA *= i;
            }

            for (int i = b; i > 0; i--)
            {
                factorialOfB *= i;
            }

            double division = factorialOfA / factorialOfB;

            Console.WriteLine($"{division:F2}");
        }
    }
}
