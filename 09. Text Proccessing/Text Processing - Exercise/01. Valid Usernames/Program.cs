using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> usernames = new List<string>();

            foreach (string word in text)
            {
                bool isValid = true;

                if (word.Length < 3 || word.Length > 16)
                {
                    continue;
                }

                foreach (char ch in word)
                {
                    if (!(char.IsDigit(ch)) &&
                        !(char.IsLetter(ch)) &&
                        (ch != '-') && 
                        (ch != '_'))
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    usernames.Add(word);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, usernames));
        }
    }
}
