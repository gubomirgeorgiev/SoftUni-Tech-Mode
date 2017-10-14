using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02MaxMethod
{
    class Program
    {
        static int GetMaxNum (int numOne, int numTwo)
        {
            return Math.Max(numOne, numTwo);
        }
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(GetMaxNum(firstNumber, secondNumber), thirdNumber));
        }
    }
}
