using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int returnedSumOfTheFirstTwo = GetSumOfTheFirstTwo(a, b);
            int returnedSubtraction = GetTheSubtractionWithTheThird(returnedSumOfTheFirstTwo, c);

            Console.WriteLine(returnedSubtraction);
        }

        private static int GetTheSubtractionWithTheThird(int returnedSumOfTheFirstTwo, int c)
        {
            return returnedSumOfTheFirstTwo - c;
        }

        private static int GetSumOfTheFirstTwo(int a, int b)
        {
            return a + b;
        }


    }
}
