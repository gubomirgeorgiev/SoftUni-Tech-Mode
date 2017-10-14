using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.NumbersInReversedOrder
{
    class Program
    {
        static double GetNumberInReverse (string intToString)
        {
            string result = "";
            for (int i = intToString.Length - 1; i >= 0; i--)
            {
                result += intToString[i];
            }
            double resul = double.Parse(result);
            return resul;
        }
        static void Main(string[] args)
        {
            double inputNum = Math.Abs(double.Parse(Console.ReadLine()));
            string stringNumber = inputNum.ToString();
            Console.WriteLine(GetNumberInReverse(stringNumber));
        }
    }
}
