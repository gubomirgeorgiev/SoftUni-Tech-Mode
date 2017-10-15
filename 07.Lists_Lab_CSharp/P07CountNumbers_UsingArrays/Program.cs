using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07CountNumbers_UsingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = input.Max();
            var counts = new int[max + 1];
            for (int i=0; i< input.Length; i++)
            {
                    counts[input[i]]++;
            }
            for(int i =0;i< counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine(i + " -> " + string.Join(" ", counts[i]));
                }
            }
        }
    }
}
