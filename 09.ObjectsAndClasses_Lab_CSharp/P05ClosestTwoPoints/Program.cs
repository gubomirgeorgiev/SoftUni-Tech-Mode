using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int intPossitions = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();
            for (int i = 0; i < intPossitions; i++)
            {
                double[] currentPoint = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                points.Add(new Point
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]
                });
            }
            var minDistance = double.MaxValue;
            Point firstpointMin = null;        
            Point secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPoint = points[i];
                    var secondPoint = points[j];

                    var currentDistance = CalculateDistance(firstPoint, secondPoint);

                    if (currentDistance < minDistance)
                    {
                        minDistance = currentDistance;
                        firstpointMin = firstPoint;
                        secondPointMin = secondPoint;
                    }

                }
            }
            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstpointMin.X}, {firstpointMin.Y})\n\r({secondPointMin.X}, {secondPointMin.Y})");
        }
        static double CalculateDistance(Point firstPoint, Point secondPoint) { 
        double diffX = firstPoint.X - secondPoint.X;
        double diffY = firstPoint.Y - secondPoint.Y;
        double powX = Math.Pow(diffX, 2);
        double powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
            }
    }
}
