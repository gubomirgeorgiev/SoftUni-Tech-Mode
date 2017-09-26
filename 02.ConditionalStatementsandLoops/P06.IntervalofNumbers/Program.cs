using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOne = int.Parse(Console.ReadLine());
            var numberTwo = int.Parse(Console.ReadLine());
            for (int i = Math.Min(numberOne,numberTwo); i <= Math.Max(numberOne, numberTwo); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
