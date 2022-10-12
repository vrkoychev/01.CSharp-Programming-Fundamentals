using System;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string returnedText = string.Empty;
            string repeatedString = RepeatedString(text, n);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatedString(string text, int n)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                repeatedString += text;
            }

            return repeatedString;
        }
    }
}
