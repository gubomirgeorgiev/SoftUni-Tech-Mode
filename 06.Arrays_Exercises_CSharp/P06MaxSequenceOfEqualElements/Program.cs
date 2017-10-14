using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int maxStart = 0;
            int maxLen = 1;
            int currentStart = 0;
            int currentLen = 1;
            for (int i = 1; i < sequance.Length; i++)
            {
                if (sequance[i] == sequance[currentStart])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i;
                }
            }
            for (int i = maxStart; i < maxStart + maxLen; i++)
                Console.Write("{0} ", sequance[i]);
        }

    }
}
