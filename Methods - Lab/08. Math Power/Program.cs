using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double returnedNumberToPower = GetNumberToPower(number, power);
            Console.WriteLine(returnedNumberToPower);
        }

        private static double GetNumberToPower(int number, int power)
        {
            double numberToPower = 1d;

            for (int i = 0; i < power; i++)
            {
                numberToPower *= number;
            }

            return numberToPower;
        }
    }
}
