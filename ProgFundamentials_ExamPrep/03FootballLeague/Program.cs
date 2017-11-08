using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string pattern = $"([{key}]+)(.*?)(\\1)";
            string inputToDecrypt = Console.ReadLine();
            List<League> output = new List<League>();
            while (inputToDecrypt != "final")
            {
                string[] split = inputToDecrypt.Split(':');
                List<long> goals = GetScore(split);
                var match = Regex.Matches(inputToDecrypt, pattern);
                List<string> team = GetTeams(match, key);
                List<League> teamsToAdd = GetTeamsToList(team, goals);
                foreach (League teamFromList in teamsToAdd)
                {
                    if (!output.Any(x => x.Team == teamFromList.Team))
                    {
                        output.Add(teamFromList);
                    }
                    else
                    {
                        output.First(x => x.Team == teamFromList.Team).Score += teamFromList.Score;
                        output.First(x => x.Team == teamFromList.Team).Goal += teamFromList.Goal;
                    }
                }
                inputToDecrypt = Console.ReadLine();
            }
            int counter = 0;
            Console.WriteLine("League standings:");
            foreach (League toPrint in output.OrderByDescending(x => x.Score).ThenBy(x => x.Team))
            {
                counter++;
                Console.WriteLine($"{counter}. {toPrint.Team} {toPrint.Score}");
            }
            Console.WriteLine($"Top 3 scored goals:");
            counter = 0;
            foreach (League topThree in output.OrderByDescending(x => x.Goal).ThenBy(x => x.Team))
            {
                counter++;
                Console.WriteLine($"- {topThree.Team} -> {topThree.Goal}");
                if (counter == 3)
                {
                    break;
                }
            }
        }

        private static List<League> GetTeamsToList(List<string> team, List<long> goal)
        {
            List<League> output = new List<League>();
            if (goal[0] > goal[1])
            {
                output.Add(new League()
                {
                    Team = team[0],
                    Score = 3,
                    Goal = goal[0]
                });
                output.Add(new League()
                {
                    Team = team[1],
                    Score = 0,
                    Goal = goal[1]
                });
            }
            else if (goal[0] < goal[1])
            {
                output.Add(new League()
                {
                    Team = team[0],
                    Score = 0,
                    Goal = goal[0]
                });
                output.Add(new League()
                {
                    Team = team[1],
                    Score = 3,
                    Goal = goal[1]

                });
            }
            else
            {
                output.Add(new League()
                {
                    Team = team[1],
                    Score = 1,
                    Goal = goal[1]
                });
                output.Add(new League()
                {
                    Team = team[0],
                    Score = 1,
                    Goal = goal[0]
                });
            }
            return output;
        }

        private static List<string> GetTeams(MatchCollection matchCol, string key)
        {
            List<string> team = new List<string>();
            StringBuilder reverse = new StringBuilder();
            char[] charArray = matchCol[0].Groups[2].Value.ToUpper().ToCharArray();
            Array.Reverse(charArray);
            team.Add(new string(charArray));
            charArray = matchCol[1].Groups[2].Value.TrimStart(key.ToCharArray()).TrimEnd(key.ToCharArray()).ToUpper().ToCharArray();
            Array.Reverse(charArray);
            team.Add(new string(charArray));
            return team;
        }

        private static List<long> GetScore(string[] inputToDecrypt)
        {
            List<long> teamScore = new List<long>();
            StringBuilder digit = new StringBuilder();
            string second = inputToDecrypt[inputToDecrypt.Length - 1];
            string first = inputToDecrypt[inputToDecrypt.Length - 2];
            for (int i = second.Length-1; i >=0; i--)
            {
                if (char.IsDigit(second[i]))
                {
                    digit.Append(second[i]);
                }
                else
                {
                    break;
                }
            }
            char[] charArray = digit.ToString().ToCharArray();
            Array.Reverse(charArray);
            teamScore.Insert(0,long.Parse(new string(charArray)));
            digit.Clear();
            for (int j = first.Length-1; j >=0; j--)
            {
                if (char.IsDigit(first[j]))
                {
                    digit.Append(first[j]);
                }
                else
                {
                    break;
                }
            }
            charArray = digit.ToString().ToCharArray();
            Array.Reverse(charArray);
            teamScore.Insert(0,long.Parse(new string(charArray)));
            digit.Clear();
            return teamScore;
        }
    }

    class League
    {
        public string Team { get; set; }
        public long Score { get; set; }
        public long Goal { get; set; }
    }
}

