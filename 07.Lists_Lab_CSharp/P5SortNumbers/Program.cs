﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().OrderBy(s =>decimal.Parse(s)).ToList();
            Console.WriteLine(string.Join(" => ", array));
        }
    }
}
