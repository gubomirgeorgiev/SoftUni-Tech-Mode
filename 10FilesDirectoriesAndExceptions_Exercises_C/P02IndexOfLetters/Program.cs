using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char[]> array = File.ReadAllLines("input.txt").Select(x=>x.ToCharArray()).ToList();
            File.Delete("output.txt");
            for (int i =0; i < array.Count; i++)
            {
                foreach (char s in array[i])
                {
                    File.AppendAllText("output.txt", (s + " -> " + (((int)s) - 97))+Environment.NewLine);
                }
                File.AppendAllText("output.txt", Environment.NewLine);
            }
        }
    }
}
