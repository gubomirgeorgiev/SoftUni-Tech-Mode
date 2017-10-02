using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P16ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());
            decimal maxEpsilon = (Math.Max(Math.Abs(numberA), Math.Abs(numberB)));
            decimal minEpsilon = (Math.Min(Math.Abs(numberA), Math.Abs(numberB)));
            if (maxEpsilon - minEpsilon < 0.000001M)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
