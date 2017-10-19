using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int p = 0;
            int start = 0;
            int lenght = 0;
            int bestStart = 0;
            int bestLenght = 0;
            for (int i=1; i<input.Count;i++)
            {
                if (input[i - 1] == input[i])
                {
                    lenght++;
                }
                else
                {
                    start = i;
                    lenght = 0;
                }
                if (lenght > bestLenght)
                {
                    bestLenght = lenght;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i<=bestStart+bestLenght; i++)
            {
                Console.Write(string.Join(" ", input[i])+ " ");
            }
        }
    }
}
