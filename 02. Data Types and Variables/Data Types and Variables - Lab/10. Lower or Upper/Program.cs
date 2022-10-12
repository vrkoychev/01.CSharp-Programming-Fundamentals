using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());

            int number = ch;

            if (number >= 97 && number <= 122)
                Console.WriteLine("lower-case");
            else if (number >= 65 && number <= 90)
                Console.WriteLine("upper-case");
        }
    }
}
