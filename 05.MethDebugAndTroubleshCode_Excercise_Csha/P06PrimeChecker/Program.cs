using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P06PrimeChecker
{
    class Program
    {
        static void IsPrime (BigInteger num, bool prime)
        {
            bool local = false;
            for (int i = 2; i <= (BigInteger)Math.Sqrt((double)num); i++)
            {
                if (num % i == 0)
                {
                    local = true;
                    break;
                }
            }
            if (local)
            {
                Console.WriteLine(prime);
            }
            else
            {
                prime = true;
                Console.WriteLine(prime);
            }
        }

        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            bool primeOrNot = false;
            if (number == 0 || number == 1)
            {
                Console.WriteLine(primeOrNot);
            }
            else if (number == 2)
            {
                primeOrNot = true;
                Console.WriteLine(primeOrNot);
            }
            else if (number > 2)
            {
                IsPrime(number, primeOrNot);
            }   
        }
    }
}
