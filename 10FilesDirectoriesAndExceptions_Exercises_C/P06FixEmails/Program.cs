using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = File.ReadAllLines("input.txt");
            //File.Delete("output.txt");
            var numbers = Directory.GetFiles(".")
                .Where(f => f.StartsWith(@".\output"))
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())
                .Where(f => f != null)
                .Select(f => f.Replace(".txt", ""))
                .Select(int.Parse);
            //.Max();

            int nextNum = 0;
            if (numbers.Any())
            {
                nextNum = numbers.Max()+1;
            }
            var outputFileName = "output_" + nextNum + ".txt";
            for (int i =0; i<file.Length; i += 2)
            {
                if (file[i]=="stop"|| file[i + 1] == "stop")
                {
                    break;
                }
                var name = file[i];
                var email = file[i + 1];
                if (email.EndsWith(".uk") || email.EndsWith(".us"))
                {
                    continue;
                }
                var output = $"{name} -> {email}"+Environment.NewLine;
                File.AppendAllText(outputFileName, output);
            }              
        }
    }
}
