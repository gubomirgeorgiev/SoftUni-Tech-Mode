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
            List<char[]> array = File.ReadAllLines("../../input.txt").Select(x=>x.ToCharArray()).ToList();
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            for (int i =0; i < array.Count; i++)
            {
                foreach (char s in array[i])
                {
                    File.AppendAllText(outputPath, (s + " -> " + (((int)s) - 97))+Environment.NewLine);
                }
                File.AppendAllText(outputPath, Environment.NewLine);
            }
        }
    }
}
