using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10CubeProperties
{
    class Program
    {
        static double GetLenght (double sideLenght, string propertie)
        {
            double output;
            switch (propertie)
            {
                case "face":
                    output = Math.Sqrt(2 * Math.Pow(sideLenght, 2));
                    break;
                case "space":
                    output = Math.Sqrt(3 * Math.Pow(sideLenght, 2));
                    break;
                case "volume":
                    output = Math.Pow(sideLenght, 3);
                    break;
                case "area":
                    output = 6*Math.Pow(sideLenght, 2);
                    break;
                default:
                    output = 0;
                    break;
            }
            return output;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Console.WriteLine("{0:F2}",GetLenght(side, parameter));
        }
    }
}
