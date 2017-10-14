using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05FibonacciNumbers
{
    class Program
    {
        static long FibonachiNumber(long num)
        {
            long secondPrecedingNumber = 0;
            long firstPrecedingNumber = 1;
            long outputNumber = 0;
            if (num < 2)
            {
                return 1;
            }
            else
            {
                for (long i = 0; i < num; i++)
                {
                    outputNumber = secondPrecedingNumber + firstPrecedingNumber;
                    secondPrecedingNumber = firstPrecedingNumber;
                    firstPrecedingNumber = outputNumber;
                }
                return outputNumber;
            }
        }
            static void Main(string[] args)
            {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(FibonachiNumber(number));
            }
        }
    }
