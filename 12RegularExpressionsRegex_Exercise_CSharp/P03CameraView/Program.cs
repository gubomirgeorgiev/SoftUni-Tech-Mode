using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P03CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] positionAndLenght = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            int m = positionAndLenght[0];
            int n = positionAndLenght[1];
            string pattern = $"\\|\\<(.{{0,{m}}})(.{{0,{n}}})";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(text);

            List<string> result = new List<string>();
            while (text.Length > match.Index + 2 && match.Success)
            {
                string matchToAdd = match.Groups[2].Value;

                if (matchToAdd.Contains("|"))
                {
                    matchToAdd = matchToAdd.Substring(0,
                        matchToAdd.IndexOf("|"));
                }

                if (matchToAdd.Contains("<"))
                {
                    matchToAdd = matchToAdd.Substring(0,
                        matchToAdd.IndexOf("<"));
                }
                result.Add(matchToAdd);
                text = text.Substring(match.Index + 2);
                match = regex.Match(text);
            }
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
