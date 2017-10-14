using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            var squareNums = new List<int>();
            foreach(int item in input)
            {
                if (Math.Sqrt(item) % 1 == 0)
                {
                    squareNums.Add(item);
                }
            }
            squareNums.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareNums));
        }
    }
}
