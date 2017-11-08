using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P02ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();
            string[] sentences = text.Split(new char[] { '!', '.', '?' }
            ,StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = "\\b"+ keyword +"\\b";
            Regex regex = new Regex(pattern);
            foreach (string sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
