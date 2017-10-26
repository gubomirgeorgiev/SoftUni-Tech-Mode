using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = File.ReadAllLines("input.txt");
            File.Delete("output.txt");
            for (int j =0; j<inputFile.Length; j++)
            {
                ushort[] array = inputFile[j].Split(' ').Select(ushort.Parse).ToArray();
                int[] count = new int[65536];

                foreach (ushort num in array)
                {
                    count[num]++;
                }

                int maxValue = count.Max();

                for (int i = 0; i < array.Length; i++)
                {
                    if (count[array[i]] == maxValue)
                    {
                        File.AppendAllText("output.txt", string.Join("", array[i])+Environment.NewLine);
                        break;
                    }
                }
            }
        }
    }
}
