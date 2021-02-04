using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Teams> teams = new List<Teams>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split('-', StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

                if (teams.Any(x => x.Team == input[1]))
                {
                    Console.WriteLine($"Team {input[1]} was already created!");
                }
                else if (teams.Any(x => x.User == input[0]))
                {
                    Console.WriteLine($"{input[0]} cannot create another team!");
                }
                else
                {
                    Teams newTeam = new Teams(input[0], input[1]);
                    teams.Add(newTeam);
                    Console.WriteLine($"Team {newTeam.Team} has been created by {newTeam.User}!");
                }
            }

            string command = Console.ReadLine();

            while (command != "end of assignment")
            {
                string[] teamInfo = command.Split("->", StringSplitOptions.RemoveEmptyEntries)
                                           .ToArray();

                string currentUser = teamInfo[0];
                string currentTeam = teamInfo[1];

                bool isTeamExist = teams.Any(x => x.Team == currentTeam);
                bool isCreatorCheating = teams.Any(x => x.User == currentUser);
                bool isAlreadyFen = teams.Any(x => x.Members.Contains(currentUser));

                if (isTeamExist && isCreatorCheating == false && isAlreadyFen == false)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Team == currentTeam);
                    teams[indexOfTeam].Members.Add(currentUser);
                }
                else if (isTeamExist == false)
                {
                    Console.WriteLine($"Team {currentTeam} does not exist!");
                }
                else if (isAlreadyFen || isCreatorCheating)
                {
                    Console.WriteLine($"Member {currentUser} cannot join team {currentTeam}!");
                }

                command = Console.ReadLine();
            }

            List<Teams> teamWithMember = teams.Where(x => x.Members.Count > 0)
                                              .OrderByDescending(x => x.Members.Count)
                                              .ThenBy(x => x.Team)
                                              .ToList();

            List<Teams> notValidTeam = teams.Where(x => x.Members.Count == 0)
                                            .OrderBy(x => x.Team)
                                            .ToList();

            foreach (var team in teamWithMember)
            {
                Console.WriteLine(team.Team);
                Console.WriteLine("- " + team.User);
                team.Members.Sort();
                Console.WriteLine(string.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in notValidTeam)
            {
                Console.WriteLine(team.Team);
            }
        }
    }
    class Teams
    {
        public Teams(string user, string team)
        {
            User = user;
            Team = team;
            Members = new List<string>();
        }

        public string User { get; set; }
        public string Team { get; set; }
        public List<string> Members { get; set; }
    }
}
