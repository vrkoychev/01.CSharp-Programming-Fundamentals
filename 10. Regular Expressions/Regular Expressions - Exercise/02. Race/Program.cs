using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listOfParticipants = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string input = Console.ReadLine();

            Dictionary<string, int> participants = new Dictionary<string, int>();

            string regexName = @"[A-Za-z]";
            string regexSum = @"\d";

            while (input != "end of race")
            {
                MatchCollection participant = Regex.Matches(input, regexName);
                MatchCollection kmTravelled = Regex.Matches(input, regexSum);

                string name = string.Empty;
                int sum = 0;

                foreach (Match item in participant)
                {
                    name += item;
                }

                foreach (Match item in kmTravelled)
                {
                    sum += int.Parse(item.ToString());
                }

                for (int i = 0; i < listOfParticipants.Length; i++)
                {
                    if (name == listOfParticipants[i])
                    {
                        if (participants.ContainsKey(name))
                        {
                            participants.Where(x => x.Value == x.Value + sum);
                        }
                        else
                        {
                            participants.Add(name, sum);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Dictionary<string, int> orderedParticipants = participants
                .OrderByDescending(x => x.Value)
                .Take(3)
                .ToDictionary(x => x.Key, x => x.Value);
            List<string> finalThreePlaces = new List<string>(orderedParticipants.Keys);

            Console.WriteLine($"1st place: {finalThreePlaces[0]}");
            Console.WriteLine($"2nd place: {finalThreePlaces[1]}");
            Console.WriteLine($"3rd place: {finalThreePlaces[2]}");
        }
    }
}
