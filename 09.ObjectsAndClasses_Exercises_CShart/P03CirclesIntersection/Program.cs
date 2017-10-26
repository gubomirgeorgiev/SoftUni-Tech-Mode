using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03CirclesIntersection
{
    class Center
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

        class Circle
    {
        public Center Center { get; set; }
        public double Radius { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circleOne = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var circleTwo = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Center one = new Center
            {
                X = circleOne.First(),
                Y = circleOne.Skip(1).First(),
            };

            Center two = new Center
            {
                X = circleTwo.First(),
                Y = circleTwo.Skip(1).First(),
            };

            Circle firstCircle = new Circle
            {
                Center = one,
                Radius = circleOne.Skip(2).First()
            };

            Circle seondCircle = new Circle
            {
                Center = two,
                Radius = circleTwo.Skip(2).First()
            };

            if (CalculateDistance(firstCircle.Center, seondCircle.Center) <= firstCircle.Radius + seondCircle.Radius)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static double CalculateDistance (Center firstPoint, Center secondPoint)
        {
            double diffX = firstPoint.X - secondPoint.X;
            double diffY = firstPoint.Y - secondPoint.Y;
            double powX = Math.Pow(diffX, 2);
            double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
    }
}
