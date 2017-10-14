using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SumArrays
{
    class Program
    {
        static int [] GetArraysSum (int [] arrOne, int [] arrTwo)
        {
            int[] arrSum = new int[Math.Max(arrOne.Length, arrTwo.Length)];
            for (int i =0; i< Math.Max(arrOne.Length, arrTwo.Length); i++)
            {
                arrSum[i] = arrOne[i % arrOne.Length] + arrTwo[i % arrTwo.Length];
            }
            return arrSum;
        }
        static void Main(string[] args)
        {
            int [] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ", GetArraysSum(firstArray, secondArray)));
        }
    }
}
