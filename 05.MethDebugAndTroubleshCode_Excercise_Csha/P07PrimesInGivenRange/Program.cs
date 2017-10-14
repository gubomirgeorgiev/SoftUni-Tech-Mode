using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07PrimesInGivenRange
{
    class Program
    {
        static StringBuilder FindPrimesInRange(int startNum, int endNum)
        {
            StringBuilder primes = new StringBuilder();
            for (int counter = startNum; counter<= endNum; counter++)
            {
                if (counter < 2)
                {

                }
                else if (counter == 2)
                {
                    primes = primes.Append(counter).Append(", ");
                }
                else if (IsPrime(counter) == true)
                {
                    primes = primes.Append(counter).Append(", ");
                }
            }
            primes.Remove(primes.Length - 2, 2);
            return primes;
        }

        static bool IsPrime(int num)
        {
            bool local = false;
            bool prime = false;
            for (int count = 2; count <= Math.Sqrt((double)num); count++)
            {
                if (num % count == 0)
                {
                    local = true;
                    break;
                }
            }
            if (local)
            {
               
            }
                else
                {
                    prime = true;
                }
            
            return prime;
        }

        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(FindPrimesInRange(startNumber, endNumber));
        }
    }
}
