using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] letters = Console.ReadLine().Split();

            string text = string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                for (int j = 0; j < letters[i].Length; j++)
                {
                    text += letters[i];
                }
            }

            Console.WriteLine(text);
        }
    }
}
