using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03ExactSumOfRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int nNumbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < nNumbers; i++)
            {
                decimal input = decimal.Parse(Console.ReadLine());
                sum += input;
            }
            Console.WriteLine(sum);
        }
    }
}
