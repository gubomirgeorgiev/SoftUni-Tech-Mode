using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string[] songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> awardsNumByOwners = new Dictionary<string, int>();
            Dictionary<string, List<string>> ownersAwards = new Dictionary<string, List<string>>();
            string stagePerformance = Console.ReadLine();
            while (stagePerformance != "dawn")
            {
                string[] performanceToArr = stagePerformance.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                string name = performanceToArr[0];
                string song = performanceToArr[1];
                string award = performanceToArr[2];
                if (!awardsNumByOwners.ContainsKey(name) && participants.Any(a => a.Contains(name)))
                {
                    if (songs.Any(s => s.Equals(song)) == true)
                    {
                        awardsNumByOwners[name] = 1;
                        ownersAwards[name] = new List<string>();
                        ownersAwards[name].Add(award);
                    }
                }
                else if (awardsNumByOwners.ContainsKey(name) && participants.Any(a => a.Contains(name)))
                {
                    if (songs.Any(s => s.Equals(song)))
                    {
                        if (!ownersAwards[name].Any(awards => awards.Contains(award)))
                        {
                            awardsNumByOwners[name] += 1;
                            ownersAwards[name].Add(award);
                        }
                    }
                }
                stagePerformance = Console.ReadLine();
            }
            awardsNumByOwners = awardsNumByOwners.OrderByDescending(a => a.Value).ThenBy(n => n.Key).ToDictionary(x => x.Key, x => x.Value);
            if (awardsNumByOwners.Count > 0)
            {
                foreach (string name in awardsNumByOwners.Keys)
                {
                    Console.Write("{0}: ", name);
                    Console.WriteLine("{0} awards", awardsNumByOwners[name]);
                    foreach (var award in ownersAwards[name].OrderBy(x => x))
                    {
                        Console.WriteLine("--{0}", award);
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
