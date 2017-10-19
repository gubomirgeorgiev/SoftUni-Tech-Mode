using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 999;
            var input = new List<string>();
            var phonebook = new SortedDictionary<string, string>();
            for (int i = 0; i < end; i++)
            {
                input = Console.ReadLine().Split().ToList();
                if (input[0].Contains("A")&&!input[0].Contains("ListAll"))
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0].Contains("S"))
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine(string.Join(" ", phonebook.Where(s => s.Key == input[1]).Select(t => t.Key + " -> " + t.Value)));
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0].Contains("ListAll"))
                {
                    Console.WriteLine(string.Join(" \r\n", phonebook.Select(t => t.Key + " -> " + t.Value)));
                }
                else if (input[0].Contains("END"))
                {
                    end = 0;
                }
            }
        }
    }
}
