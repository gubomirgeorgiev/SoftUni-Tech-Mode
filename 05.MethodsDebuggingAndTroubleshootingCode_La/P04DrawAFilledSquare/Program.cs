using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04DrawAFilledSquare
{
    class Program
    {
        static void PrintHeaderRow(int num)
        {
            Console.WriteLine(new string('-', num * 2));
        }
        static void PrintMiddleRow (int num)
        {
            Console.Write("-");
            for (int row = 0; row < num - 1; row++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeaderRow(input);
            for (int col=1; col<= input - 2; col++)
            {
                PrintMiddleRow(input);
            }
            PrintHeaderRow(input);
        }
    }
}
