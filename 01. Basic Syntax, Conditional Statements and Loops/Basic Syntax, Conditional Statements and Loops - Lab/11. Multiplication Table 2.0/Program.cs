using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mult = int.Parse(Console.ReadLine());

            for (int i = mult; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }

            if (mult > 10)
                Console.WriteLine($"{n} X {mult} = {n * mult}");
        }
    }
}
