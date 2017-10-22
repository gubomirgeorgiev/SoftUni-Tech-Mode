﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P03BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            for (int i=2; i<=num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
    }
}
