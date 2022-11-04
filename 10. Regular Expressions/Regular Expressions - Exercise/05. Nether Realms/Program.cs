using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < demons.Length; i++)
            {
                string currentDemon = demons[i];

                string lettersPattern = @"[^\d\.\+\-\*\/]+";
                MatchCollection letters = Regex.Matches(currentDemon, lettersPattern);

                int health = 0;
                foreach (Match ch in letters)
                {
                    char[] symbols = ch.ToString().ToCharArray();

                    foreach (char symbol in symbols)
                    {
                        int num = symbol;
                        health += num;
                    }
                }

                string numPattern = @"(\-|\+)*([0-9]+\.)*[0-9]+";
                MatchCollection nums = Regex.Matches(currentDemon, numPattern);

                decimal damage = 0;
                foreach()

            }
        }
    }
}
