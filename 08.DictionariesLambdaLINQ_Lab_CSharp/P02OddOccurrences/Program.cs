using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToList();
            var dict = new Dictionary<string, int>();
            foreach (string text in input)
            {
                if (dict.ContainsKey(text))
                {
                    dict[text]++;
                }
                else
                {
                    dict[text] = 1;
                }
            }
            var results = new List<string>();
            foreach (var value in dict)
            {
                if (value.Value % 2 != 0)
                {
                    results.Add(value.Key);
                    
                }
            }
            Console.Write(string.Join(", ", results));
            Console.WriteLine();
        }
    }
}
