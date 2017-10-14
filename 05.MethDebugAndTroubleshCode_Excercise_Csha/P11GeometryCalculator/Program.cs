using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11GeometryCalculator
{
    class Program
    {
        static double GetAreaOfFiguresWithTwoParameter (string figure, double parameterOne, double parameterTwo)
        {
            double area;
            switch (figure)
            {
                case "triangle":
                    area = (parameterOne / 2) * parameterTwo;
                    break;
                case "rectangle":
                    area = parameterOne * parameterTwo;
                    break;
                default:
                    area = 0;
                    break;
            }
            return area;
        }

        static double GetAreaOfFiguresWithOneParameter(string figure, double parameter)
        {
            double area;
            switch (figure)
            {
                case "square":
                    area = Math.Pow(parameter, 2);
                    break;
                case "circle":
                    area = Math.PI * Math.Pow(parameter,2);
                    break;
                default:
                    area = 0;
                    break;
            }
            return area;
        }

        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            if (figureType.Equals("triangle") || figureType.Equals("rectangle"))
            {
                double firstParameter = double.Parse(Console.ReadLine());
                double secondParameter = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",GetAreaOfFiguresWithTwoParameter(figureType, firstParameter, secondParameter));
            }else
            {
                double firstParameter = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}",GetAreaOfFiguresWithOneParameter(figureType, firstParameter));
            }
        }
    }
}
