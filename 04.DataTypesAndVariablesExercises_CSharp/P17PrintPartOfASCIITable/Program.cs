using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P17PrintPartOfASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputOne = int.Parse(Console.ReadLine());
            int inputTwo = int.Parse(Console.ReadLine());
            for (int staringPoint = inputOne; inputOne <= inputTwo; inputOne++)
            {
                char charUnicod = (char)inputOne;
                Console.Write($"{charUnicod.ToString()} ");
            }
        }
    }
}
