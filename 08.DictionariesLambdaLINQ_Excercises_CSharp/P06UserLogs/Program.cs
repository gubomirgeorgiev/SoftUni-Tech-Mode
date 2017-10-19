using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            int commaCounter = 0;
            while (input != "end")
            {
                //Collect usernames
                string[] takeUser = input.Split(' ').Skip(2).Take(1).ToArray();
                string[] username = takeUser[0].Split('=').Skip(1).Take(1).ToArray();
                //collect IP addresses 
                string[] takeIp = input.Split(' ').Take(1).ToArray();
                string[] ipAddress = takeIp[0].Split('=').Skip(1).Take(1).ToArray();
                //Collect message
                string[] takeMessage = input.Split(' ').Skip(1).Take(1).ToArray();
                string[] message = takeMessage[0].Split('=').Skip(1).Take(1).ToArray();
                //Console.WriteLine(string.Join(" ", username)+" "+ string.Join(" ", ipAddress)+" "+ string.Join(" ", message));
                if (!userLogs.ContainsKey(username[0]))
                {
                    userLogs[username[0]] = new Dictionary<string, int>();
                    userLogs[username[0]].Add(ipAddress[0], 1);
                }
                else
                {
                    if (!userLogs[username[0]].ContainsKey(ipAddress[0]))
                    {
                        userLogs[username[0]].Add(ipAddress[0], 1);
                    }
                    else
                    {
                        userLogs[username[0]][ipAddress[0]]++;
                    }
                }
                input = Console.ReadLine();
            }
            foreach (string user in userLogs.Keys)
            {
                Console.WriteLine(user + ": ");
                foreach (string ip in userLogs[user].Keys.Distinct())
                {
                    Console.Write(string.Join("", ip + " => "));
                    Console.Write(string.Join("", userLogs[user][ip]));
                    commaCounter++;
                    if (commaCounter > userLogs[user].Values.Count - 1)
                    {
                        Console.WriteLine(".");
                        commaCounter = 0;
                    }
                    else
                    {
                        Console.Write(", ");
                    } 
                }
            }
        }
    }
}
