using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> array = File.ReadAllLines("../../input.txt").ToList();
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            for (int j=0; j<array.Count; j++)
            {
                int[] sequance = array[j]
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
                for (int output = maxStart; output < maxStart + maxLen; output++)
                {
                    if (output<(maxStart + maxLen) - 1)
                    {
                        File.AppendAllText(outputPath, $"{sequance[output]} ");
                    }
                    else
                    {
                        File.AppendAllText(outputPath, $"{sequance[output]}");
                    }
                }
                File.AppendAllText(outputPath, Environment.NewLine);
            }
        }
    }
}
