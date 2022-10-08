using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Addition(operation, a, b);
            Multiplication(operation, a, b);
            Subtraction(operation, a, b);
            Division(operation, a, b);
        }

        private static void Division(string operation, int a, int b)
        {
            if (operation == "divide")
            {
                Console.WriteLine($"{a / b}");
            }
        }

        private static void Subtraction(string operation, int a, int b)
        {
            if (operation == "subtract")
            {
                Console.WriteLine($"{a - b}");
            }
        }

        private static void Multiplication(string operation, int a, int b)
        {
            if (operation == "multiply")
            {
                Console.WriteLine($"{a * b}");
            }
        }

        private static void Addition(string action, int a, int b)
        {
            if (action == "add")
            {
                Console.WriteLine($"{a + b}");
            }
        }
    }
}
