using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Random randomNumGen = new Random();
            string swapPos1="";
            string swapPos2 = "";
            for (int i = 0; i< input.Length; i++)
            {
                int pos2 = randomNumGen.Next(i,input.Length);
                swapPos1 = input[i];
                swapPos2 = input[pos2];
                input[i] = swapPos2;
                input[pos2]= swapPos1;

            }
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
