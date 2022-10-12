using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j > 0; j /= 10)
                {
                    int currNum = j;
                    sum += currNum % 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                    Console.WriteLine($"{i} -> True");
                else
                    Console.WriteLine($"{i} -> False");

                sum = 0;
            }

        }
    }
}
