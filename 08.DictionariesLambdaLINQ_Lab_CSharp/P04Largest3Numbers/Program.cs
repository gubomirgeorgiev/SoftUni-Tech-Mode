using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstThreeLargestNumbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n=>n).Take(3).ToList();
            Console.WriteLine(string.Join(" ", firstThreeLargestNumbers));
        }
    }
}
