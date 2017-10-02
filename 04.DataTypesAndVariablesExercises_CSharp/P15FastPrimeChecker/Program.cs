using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int tailRangeNumber = int.Parse(Console.ReadLine());
            for (int number = 2; number <= tailRangeNumber; number++)
            {
                bool result = true;
                for (int divider = 2; divider <= Math.Sqrt(number); divider++)
                {
                    if (number % divider == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{number} -> {result}");
            }
        }
    }
}
