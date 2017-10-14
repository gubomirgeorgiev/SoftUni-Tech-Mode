using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool [] primeArray = new bool [input+1];
            primeArray[0] = primeArray[1] = false;
            for (int i = 2; i <=input; i++)
            {
                primeArray[i] = true;
            }

            for (int i = 0; i <= input; i++)
            {
                if (primeArray[i] == true)
                {
                    Console.Write(i + " ");

                    int p = i;
                    int multiplier = 1;
                    while (p <= input)
                    {
                        primeArray[p] = false;
                        multiplier++;
                        p = i * multiplier;
                    }
                }
            }
        }
    }
}
