using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());
            var numList = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i =0; i< range-1; i++)
            {
                numList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum = "+numList.Sum());
            Console.WriteLine("Min = "+ numList.Min());
            Console.WriteLine("Max = " + numList.Max());
            Console.WriteLine("Average = " + numList.Average());
        }
    }
}
