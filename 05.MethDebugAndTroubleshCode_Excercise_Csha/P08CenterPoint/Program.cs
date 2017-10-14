using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08CenterPoint
{
    class Program
    {
        static string GetClosestToTheCenterPoint (double pointX1, double pointY1, double pointX2, double pointY2)
        {
            String output = "";
            if (Math.Pow(pointX1,2)+ Math.Pow(pointY1, 2)< Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2))
            {
                output = "(" + pointX1 + ", " + pointY1 + ")";
            }
            else if (Math.Pow(pointX1, 2) + Math.Pow(pointY1, 2) > Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2))
            {
                output = "(" + pointX2 + ", " + pointY2 + ")";
            }
            else
            {
                output = "(" + pointX1 + ", " + pointY1 + ")";
            }
            return output;
        }
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());
            Console.WriteLine(GetClosestToTheCenterPoint(firstNum, secondNum, thirdNum, fourthNum));
        }
    }
}
