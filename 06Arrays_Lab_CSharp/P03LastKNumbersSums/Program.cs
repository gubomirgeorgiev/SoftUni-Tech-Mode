using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03LastKNumbersSums
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long[] seq = new long[n];
            long sum = 0;
            seq[0] = 1;
            for (long nElements = 1; nElements < n; nElements++)
            {
                for (long kElements = nElements-k; kElements <= nElements; kElements++)
                {
                    if (kElements >= 0)
                    {
                        sum += seq[kElements];
                    }
                }
                seq[nElements] = sum;
                sum = 0;
            }
            Console.WriteLine(string.Join(" ",seq));
        }
    }
}
