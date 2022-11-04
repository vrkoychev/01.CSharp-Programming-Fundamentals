using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string text = Console.ReadLine();

            MatchCollection matches = Regex.Matches(text, pattern);
            List<string> numbers = new List<string>();

            foreach (Match match in matches)
            {
                numbers.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
