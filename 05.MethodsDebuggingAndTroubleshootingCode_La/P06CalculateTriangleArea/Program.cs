using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06CalculateTriangleArea
{
    class Program
    {
        static double GetTriangleArea (double width, double height)
        {
            return width * height / 2;
        }
        static void Main(string[] args)
        {
            var widthInput = double.Parse(Console.ReadLine());
            var heightInput = double.Parse(Console.ReadLine());
            Console.WriteLine(GetTriangleArea(widthInput, heightInput));
        }
    }
}
