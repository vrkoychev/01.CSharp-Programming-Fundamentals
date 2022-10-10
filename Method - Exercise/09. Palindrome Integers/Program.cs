using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = PalindromeInteger(text);
        }

        private static string PalindromeInteger(string text)
        {
            while (text != "END")
            {
                string reverse = string.Empty;

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reverse += text[i];
                }

                if (text == reverse)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false");

                text = Console.ReadLine();
            }

            return text;
        }
    }
}
