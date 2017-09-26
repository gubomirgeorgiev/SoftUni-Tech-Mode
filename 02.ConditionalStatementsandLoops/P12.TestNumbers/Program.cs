using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            int stopCounter = 0;
            int stopSum=0;
            for (int i=N; i>=1; i--)
            {
                for (int j = 1; j<=M; j++)
                {
                    sum = sum + (3 * (i * j));
                    counter ++;
                    try
                    {
                        if (sum >= max)
                        {
                            throw new Exception();
                            
                        }
                    }
                    catch 
                    {
                        stopSum = sum;
                        stopCounter = counter;
                        i = 0;
                        j = 0;
                        break;
                    }
                }
            }
            if (sum >= max)
            {
                Console.WriteLine("{0} combinations",stopCounter);
                Console.WriteLine($"Sum: {stopSum} >= {max}");
            } else
            {
                Console.WriteLine("{0} combinations", counter);
                Console.WriteLine("Sum: {0}", sum);
            }
        }
    }
}
