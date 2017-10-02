using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());        
            Console.WriteLine($"{num.ToString("X").ToUpper()}\n{Convert.ToString(num, 2)}");
        }
    }
}
