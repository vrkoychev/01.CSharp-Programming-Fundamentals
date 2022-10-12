using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleCharacters(text);
        }

        private static void MiddleCharacters(string text)
        {
            int counter = 0;

            foreach (var ch in text)
            {
                counter++;
            }

            if (counter % 2 == 0)
            {
                int middleIndex1 = counter / 2 - 1;
                int middleIndex2 = counter / 2;

                Console.WriteLine($"{text[middleIndex1]}{text[middleIndex2]}");
            }
            else
            {
                int middleIndex = counter / 2;

                Console.WriteLine($"{text[middleIndex]}");
            }
        }
    }
}
