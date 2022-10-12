using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int numCopy = n;

            int factorialSum = 0;

            while (numCopy != 0)
            {
                int lastdigit = numCopy % 10;
                numCopy /= 10;

                int sum = 1;
                for (int i = 2; i <= lastdigit; i++)
                {
                    sum *= i;
                }

                factorialSum += sum;
            }

            if (factorialSum != n)
                Console.WriteLine("no");
            else
                Console.WriteLine("yes");
        }
    }
}
