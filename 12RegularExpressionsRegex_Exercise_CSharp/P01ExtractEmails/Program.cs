using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace P01ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([\w.-]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(text);
            foreach (Match email in match)
            {
                string emailMatch = email.ToString();
                if (!(emailMatch.StartsWith(".") || emailMatch.StartsWith("-") || emailMatch.StartsWith("_")
                    || emailMatch.EndsWith(".") || emailMatch.EndsWith("-") || emailMatch.EndsWith("_")))
                {
                    Console.WriteLine(email.Value);
                }
            }
        }
    }
}
