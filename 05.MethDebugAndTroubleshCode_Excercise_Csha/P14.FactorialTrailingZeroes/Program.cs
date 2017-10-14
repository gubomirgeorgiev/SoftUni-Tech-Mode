using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P14.FactorialTrailingZeroes
{
    class Program
    {
        static BigInteger GetFactorial (BigInteger num)
        {
            BigInteger factorial = num;
            for (BigInteger counter = num-1; counter>=1; counter--)
            {
                factorial = factorial * counter;
            }
            return factorial;
        }

        static BigInteger GetTrailingZeroes (BigInteger num)
        {
            int counter = 0;
            while (num % 10 == 0)
            {
                counter++;
                num = num / 10;
            }
            return counter;
        }

        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(GetTrailingZeroes(GetFactorial(number)));
        }
    }
}
