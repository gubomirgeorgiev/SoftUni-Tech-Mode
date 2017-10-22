using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] firstPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] secondPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            // X is public static double, that's why you don't need new Point
           
            //Y is only public double, and you need new Point
            Point first = new Point
            {
                X = firstPoint[0],
            Y = firstPoint[1]
            };

            
            Point second = new Point
            {
                X = secondPoint[0],
            Y = secondPoint[1]
            };

            double result = CalculateDistance(first, second);
            Console.WriteLine($"{result:F3}");
        }


        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            double diffX = firstPoint.X - secondPoint.Y;
            double diffY = firstPoint.Y - secondPoint.Y;
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
