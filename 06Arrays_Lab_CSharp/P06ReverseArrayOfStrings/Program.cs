using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06ReverseArrayOfStrings
{
    class Program
    {
        static void GetArrayReversed (string[] arr, int lenght)
        {
            string[] reversedArr = arr.Reverse().ToArray();
                Console.Write(string.Join(" ", reversedArr) + " ");
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            GetArrayReversed(input, input.Length);
        }
    }
}
