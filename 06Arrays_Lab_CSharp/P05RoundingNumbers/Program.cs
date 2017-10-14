using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05RoundingNumbers
{
    class Program
    {
        static void GetRoundNumbersAwayFromZero (double[] arr, int lenght)
        {
            double[] nums = arr;
            int[] roundedNums = new int [lenght];
            for (int i = 0; i<lenght; i++)
            {
                roundedNums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(nums[i]+" => "+string.Join(" \r\n", roundedNums[i]));
            }
        }

        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            GetRoundNumbersAwayFromZero(numbers, numbers.Length);
        }
    }
}
