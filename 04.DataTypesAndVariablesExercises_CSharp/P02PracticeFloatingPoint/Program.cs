using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02PracticeFloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = decimal.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            decimal thirdNum = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum}\n{secondNum}\n{thirdNum}");
        }
    }
}
