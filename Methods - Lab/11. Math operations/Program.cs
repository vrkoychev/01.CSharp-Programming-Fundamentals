using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operation = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            double result = Calculate(a, @operation, b);
            Console.WriteLine(result);
        }

        private static double Calculate(int a, string operation, int b)
        {
            double sum = 0;

            switch (@operation)
            {
                case "+":
                    sum = a + b;
                    break;
                case "-":
                    sum = a - b;
                    break;
                case "/":
                    sum = a / b;
                    break;
                case "*":
                    sum = a * b;
                    break;
            }

            return sum;
        }
    }
}
