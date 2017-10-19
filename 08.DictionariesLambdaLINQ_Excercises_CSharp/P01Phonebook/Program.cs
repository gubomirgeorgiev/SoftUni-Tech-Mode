using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 999;
            var input = new List <string>();
            var phonebook = new Dictionary<string, string>();
            for (int i=0;i<end;i++)
            {
                input = Console.ReadLine().Split().ToList();
                if (input[0].Contains("A"))
                {
                    phonebook[input[1]]=input[2];
                }
                else if (input[0].Contains("S"))
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                            Console.WriteLine(string.Join(" ", phonebook.Where(s=>s.Key== input[1]).Select(t=>t.Key+ " -> "+ t.Value)));
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else
                {
                    end = 0;
                }
            }
        }
    }
}
