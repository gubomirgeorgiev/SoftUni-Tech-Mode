using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputFile = File.ReadAllLines("input.txt").ToList();
            File.Delete("output.txt");
            
            
            for (int line =0; line < inputFile.Count; line++)
            {
                var index = -1;
                var array = (string.Join("", inputFile[line])).Split().Select(int.Parse).ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    var leftSum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += array[j];
                    }
                    var rightSume = 0;
                    for (int p = array.Length - 1; p > i; p--)
                    {
                        rightSume += array[p];
                    }
                    if (leftSum == rightSume)
                    {
                        index = i;
                    }
                }
                if (index == -1)
                {
                    File.AppendAllText("output.txt", "no" + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText("output.txt", index + Environment.NewLine);
                }
            }
        }
    }
}
