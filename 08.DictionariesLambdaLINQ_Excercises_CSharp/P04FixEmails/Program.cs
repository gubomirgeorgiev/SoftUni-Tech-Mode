using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 999;
            List<string> input = new List<string>(); ;
            var dict = new Dictionary<string, string>();
            input.Add("  ");
            for (int i=1; i < end; i++)
            {
                input.Add(Console.ReadLine());
                if (i % 2 != 0)
                {
                    if (input.ElementAt(i) == "stop")
                    {
                        end = 0;
                    }
                    else
                    {
                        dict[input.ElementAt(i)] = "";
                    }
                }
                else
                {
                    List<string> email = input.ElementAt(i).Split('.').ToList();
                    if (email.ElementAt(0) == "stop")
                    {
                        end = 0;
                    }
                    if (email.ElementAt(1) == "bg")
                    {
                        dict[input.ElementAt(i - 1)] += input.ElementAt(i);
                    }
                    else
                    {
                        dict.Remove(input.ElementAt(i - 1));
                    }
                }
            }
            Console.WriteLine(string.Join(" \r\n", dict.Select(t => t.Key + " -> " + t.Value)));
        }
    }
}
