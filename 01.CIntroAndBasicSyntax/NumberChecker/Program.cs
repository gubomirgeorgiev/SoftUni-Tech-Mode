using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var input = Console.ReadLine();
                int i = Convert.ToInt16(input);
                Console.WriteLine("It is a number.");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
