using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string encryptedText = string.Empty;

            foreach (char ch in text)
            {
                int n = (int)ch;
                n += 3;
                char newChar = (char)n;
                encryptedText += newChar;
            }

            Console.WriteLine(encryptedText);
        }
    }
}
