using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07MathPower
{
    class Program
    {
        static double GetNumberPow (double number, double pow)
        {
            double powNumber = 1;
            for (int i = 0; i<pow; i++)
            {
                powNumber *= number;

            }
            return powNumber;
        }
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            double inputPower = double.Parse(Console.ReadLine());
            Console.WriteLine(GetNumberPow(inputNumber, inputPower));
        }
    }
}
