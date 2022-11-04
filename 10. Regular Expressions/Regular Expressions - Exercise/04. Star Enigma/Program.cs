using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                string pattern = @"\@([A-Za-z]+)[^\@\-\!\:\>]*?\:[\d]+[^\@\-\!\:\>]*?\!(A|D)\![^\@\-\!\:\>]*?\-\>(\d+)";

                Match data = Regex.Match(decryptedMessage, pattern);

                if (data.Success)
                {
                    string planet = data.Groups[1].Value;
                    string attackInfo = data.Groups[2].Value;

                    if (attackInfo == "A")
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackInfo == "D")
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            PrintPlanets(attackedPlanets, destroyedPlanets);
        }

        private static void PrintPlanets(List<string> attackedPlanets, List<string> destroyedPlanets)
        {
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (string planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (string planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }

        private static string DecryptMessage(string encryptedMessage)
        {
            int key = GetEncryptedKey(encryptedMessage);

            StringBuilder decryptedMessage = new StringBuilder();

            foreach (char ch in encryptedMessage)
            {
                char decryptedCh = (char)(ch - key);
                decryptedMessage.Append(decryptedCh);
            }

            return decryptedMessage.ToString();
        }

        private static int GetEncryptedKey(string encryptedMessage)
        {
            string encryptedPattern = @"[starSTAR]";

            MatchCollection encryptedKeys = Regex.Matches(encryptedMessage, encryptedPattern);

            int key = encryptedKeys.Count;

            return key;
        }
    }
}
