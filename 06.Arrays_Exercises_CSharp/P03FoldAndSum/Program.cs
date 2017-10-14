using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03FoldAndSum
{
    class Program
    {
        static int [] GetSumOfFoldedArr(int[] arr, int k)
        {
            int[] leftArray = new int[k];
            int[] midArray = new int[2 * k];
            int[] rightArray = new int[k];
            leftArray = arr.Take(k).Reverse().ToArray();
            rightArray = arr.Skip(3 * k).Reverse().Take(k).ToArray();
            midArray = arr.Skip(k).Take(2*k).ToArray();
            int[] output = new int[2 * k];
            for (int i =0; i<k; i++)
            {
                output[i] = midArray[i] + leftArray[i];
                output[i + k] = midArray[i + k] + rightArray[i];
            }
            return output;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            Console.WriteLine(string.Join(" ", GetSumOfFoldedArr(input, k))); 
        }
    }
}
