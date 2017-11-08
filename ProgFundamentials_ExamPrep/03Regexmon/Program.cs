using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex didimonPattern = new Regex("([^a-z-A-Z\\-\\n]+)");
            Regex bojomonPattern = new Regex("([a-zA-Z]*?[\\-]{1}[a-zA-Z]+)");
            while(didimonPattern.IsMatch(input)|| bojomonPattern.IsMatch(input))
            {
                //Match match = didimonPattern.Match(input);
                if (didimonPattern.IsMatch(input))
                {
                    Console.WriteLine(didimonPattern.Match(input).Value.ToString());
                    input = input.Substring(didimonPattern.Match(input).Index+ didimonPattern.Match(input).Length);
                }
                else
                {
                    break;
                }
                //MatchCollection match2 = bojomonPattern.Matches(input);
                if (bojomonPattern.IsMatch(input))
                {
                    Console.WriteLine(bojomonPattern.Match(input).Value);
                    input = input.Substring(bojomonPattern.Match(input).Index + bojomonPattern.Match(input).Length);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
