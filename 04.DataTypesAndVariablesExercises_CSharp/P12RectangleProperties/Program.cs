using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine($"{(2*width)+(2*height)}\n{width* height}\n{Math.Sqrt(Math.Pow(width,2)+ Math.Pow(height, 2))}");
        }
    }
}
