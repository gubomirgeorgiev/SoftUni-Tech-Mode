﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Pyramid Volume: {0:F2}", ((lenght*width*height)/3));

        }
    }
}
