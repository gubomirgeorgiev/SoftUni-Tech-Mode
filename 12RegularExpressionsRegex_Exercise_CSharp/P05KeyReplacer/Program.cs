using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P05KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyString = Console.ReadLine().Split(new char[] { '\\', '<', '|' });
            string textStrin = Console.ReadLine();
            string start = "";
            string end = "";
            string output = "";
            if (keyString.Length >= 3)
            {
                start = keyString[0];
                end = keyString[keyString.Length - 1];
                string pattern = $"{start}([\\s\\S]*?){end}";
                Regex regex = new Regex(pattern);
                MatchCollection match = regex.Matches(textStrin);
                foreach(Match word in match)
                {
                    output += word.Value.Substring(start.Length, word.Value.Length - (end.Length + start.Length));
                }
            }
            if (output == "")
            {
                output = "Empty result";
            }
            Console.WriteLine(output);
        }
    }
}
