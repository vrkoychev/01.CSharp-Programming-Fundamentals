using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    class Team
    {
        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }

        public List<string> Members { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            RegisterTeams(n, teams);

            string input = Console.ReadLine();

            while (input != "end of assignment")
            {
                string[] data = Console.ReadLine().Split("->").ToArray();

                string user = data[0];
                string teamName = data[1];

                if (!(teams.Any(x => x.TeamName == teamName)))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    input = Console.ReadLine();
                    continue;
                }

                if (teams.Any(x => x.Creator == user) || teams.Any(x => x.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Team existingTeam = teams.First(x => x.TeamName == teamName);

                    existingTeam.Members.Add(user);
                }
            }

            var teamsDisband = teams.Where(x => x.Members.Count == 0).Select(x => x.TeamName).ToList();

            foreach (var team in teams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.TeamName))
            {
                if (team.Members.Count == 0)
                {
                    continue;
                }

                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");

                foreach (var name in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {name}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in teamsDisband.OrderBy(x => x))
            {
                Console.WriteLine(item);
            }
        }

        private static void RegisterTeams(int n, List<Team> teams)
        {
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split('-').ToArray();

                string creator = data[0];
                string teamName = data[1];

                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(x => x.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team(creator, teamName);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }
    }
}
