using System;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    output += text[i];
                }
            }

            output += text[text.Length - 1];

            Console.WriteLine(output);
        }
    }
}
