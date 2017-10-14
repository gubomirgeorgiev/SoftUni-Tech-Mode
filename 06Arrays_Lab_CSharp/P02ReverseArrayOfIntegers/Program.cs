using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02ReverseArrayOfIntegers
{
    class Program
    { 
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] nums = new int[input];
            for (int i =0; i < input; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int numsBackward = nums.Length-1; numsBackward>=0; numsBackward--)
            {
                Console.WriteLine(nums[numsBackward]);
            }
        }
    }
}
