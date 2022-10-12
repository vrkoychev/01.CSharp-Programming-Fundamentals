using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VowelsCount(text);
        }

        private static void VowelsCount(string text)
        {
            int count = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a' || text[i] == 'A')
                    count++;

                if (text[i] == 'e' || text[i] == 'E')
                    count++;

                if (text[i] == 'i' || text[i] == 'I')
                    count++;

                if (text[i] == 'o' || text[i] == 'O')
                    count++;

                if (text[i] == 'u' || text[i] == 'U')
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
