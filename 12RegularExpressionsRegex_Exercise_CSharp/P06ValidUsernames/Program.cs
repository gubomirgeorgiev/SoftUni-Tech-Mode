using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P06ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '/', '\\', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => !String.IsNullOrEmpty(x)&&char.IsLetter(x[0])&&(x.Length>=3&&x.Length<=25)).ToArray();
            string pattern = "\\w";
            List<string> output = new List<string>();
            int twoUsernamesLenght = 0;
            List<string> matchedUsernames = new List<string>();
            Regex regex = new Regex(pattern);
            foreach (string username in input)
            {
                if (regex.IsMatch(username))
                {
                    matchedUsernames.Add(username);
                }
            }
            if ((matchedUsernames.Count) % 2 == 0)
            {
                for (int i = 0; i < matchedUsernames.Count; i += 2)
                {
                    if (matchedUsernames[i].Length + matchedUsernames[i + 1].Length > twoUsernamesLenght)
                    {
                        twoUsernamesLenght = matchedUsernames[i].Length + matchedUsernames[i + 1].Length;
                        output.Clear();
                        output.Add(matchedUsernames[i]);
                        output.Add(matchedUsernames[i + 1]); 
                    }
                }
            }
            else if ((matchedUsernames.Count) % 2 != 0&& matchedUsernames.Count>1)
            {
                for (int i = 0; i < matchedUsernames.Count; i += 2)
                {
                    if (i == matchedUsernames.Count - 1)
                    {
                        if (matchedUsernames[i-1].Length + matchedUsernames[i].Length > twoUsernamesLenght)
                        {
                            output.Clear();
                            output.Add(matchedUsernames[i-1]);
                            output.Add(matchedUsernames[i]);
                            break;
                        }
                        break;
                    }
                    if (matchedUsernames[i].Length + matchedUsernames[i + 1].Length > twoUsernamesLenght)
                    {
                        twoUsernamesLenght = matchedUsernames[i].Length + matchedUsernames[i + 1].Length;
                        output.Clear();
                        output.Add(matchedUsernames[i]);
                        output.Add(matchedUsernames[i + 1]);
                    }
                }
            }
            if (matchedUsernames.Count == 1)
            {
                Console.WriteLine(matchedUsernames[0]);
            }
            else
            {
                Console.WriteLine(output[0]);
                Console.WriteLine(output[1]);
            }
        }
    }
}
