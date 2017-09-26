using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 999;
            for (int i =0; i < counter; i++)
            {
                int number =int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine("The number is: "+ Math.Abs(number));
                    counter = 0;
                }
            }
        }
    }
}
