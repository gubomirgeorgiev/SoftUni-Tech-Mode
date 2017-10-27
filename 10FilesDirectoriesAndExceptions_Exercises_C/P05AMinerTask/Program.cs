using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = 999;
            var dict = new Dictionary<string, int>();
            string[] array = File.ReadAllLines("../../input.txt");
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            List<string> input = new List<string>();
            input.Add("ne");
            for (int i = 1; i < end; i++)
            {
                input.Add(array[i-1]);
                if (i % 2 != 0)
                {
                    if (input.ElementAt(i) == "stop")
                    {
                        end = 0;
                    }
                    if (!dict.ContainsKey(input.ElementAt(i)) && input.ElementAt(i) != "stop")
                    {
                        dict[input.ElementAt(i)] = 0;
                    }
                }
                else
                {
                    if (input.ElementAt(i) == "stop")
                    {
                        end = 0;
                        dict.Remove("stop");
                    }
                    else
                    {
                        dict[input.ElementAt(i - 1)] += int.Parse(input[i]);
                    }
                }
            }
            File.AppendAllText(outputPath, string.Join(" \r\n", dict.Select(t => t.Key + " -> " + t.Value))+Environment.NewLine);
        }
    }
}
