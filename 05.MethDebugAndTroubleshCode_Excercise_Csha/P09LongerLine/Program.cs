using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09LongerLine
{
    class Program
    {
        static double GetDistanceBetweenTwoPoints (double pointX1, double pointY1, double pointX2, double pointY2)
        {
            double output = Math.Sqrt(Math.Pow((pointX2- pointX1),2)+Math.Pow((pointY2- pointY1),2));
            return output;
        }
        static string GetLongerLine (double pointX1, double pointY1, double pointX2, double pointY2, double pointX3, double pointY3, double pointX4, double pointY4)
        {
            String output = "";
            if (GetDistanceBetweenTwoPoints(pointX1, pointY1, pointX2, pointY2) > GetDistanceBetweenTwoPoints(pointX3, pointY3, pointX4, pointY4))
            {
                if (Math.Pow(pointX1, 2) + Math.Pow(pointY1, 2) <= Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2))
                {
                    output = "(" + pointX1 + ", " + pointY1 + ")"+"(" + pointX2 + ", " + pointY2 + ")";
                }
                else
                {
                    output = "(" + pointX2 + ", " + pointY2 + ")" + "(" + pointX1 + ", " + pointY1 + ")";
                }
            }
            else if (GetDistanceBetweenTwoPoints(pointX1, pointY1, pointX2, pointY2) < GetDistanceBetweenTwoPoints(pointX3, pointY3, pointX4, pointY4))
            {
                if (Math.Pow(pointX3, 2) + Math.Pow(pointY3, 2) <= Math.Pow(pointX4, 2) + Math.Pow(pointY4, 2))
                {
                    output = "(" + pointX3 + ", " + pointY3 + ")" + "(" + pointX4 + ", " + pointY4 + ")";
                }
                else
                {
                    output = "(" + pointX4 + ", " + pointY4 + ")" + "(" + pointX3 + ", " + pointY3 + ")";
                }
            }
            else
            {
                if (Math.Pow(pointX1, 2) + Math.Pow(pointY1, 2) <= Math.Pow(pointX2, 2) + Math.Pow(pointY2, 2))
                {
                    output = "(" + pointX1 + ", " + pointY1 + ")" + "(" + pointX2 + ", " + pointY2 + ")";
                }
                else
                {
                    output = "(" + pointX2 + ", " + pointY2 + ")" + "(" + pointX1 + ", " + pointY1 + ")";
                }
            }
            return output;
        }

        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            double fourthNum = double.Parse(Console.ReadLine());
            double fifthNum = double.Parse(Console.ReadLine());
            double sixthNum = double.Parse(Console.ReadLine());
            double seventhNum = double.Parse(Console.ReadLine());
            double eightNum = double.Parse(Console.ReadLine());
            Console.WriteLine(GetLongerLine(firstNum, secondNum, thirdNum, fourthNum, fifthNum, sixthNum, seventhNum, eightNum));
        }
    }
}
