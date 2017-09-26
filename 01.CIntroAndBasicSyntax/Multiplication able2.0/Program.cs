using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_able2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var multiplicNum = int.Parse(Console.ReadLine());
            if (multiplicNum <= 10) {
                for (int i = multiplicNum; i <= 10; i++)
                {
                    Console.WriteLine($"{num} X {i} = {(num * i)}");
                }
            }     
                else
            {
                Console.WriteLine($"{num} X {multiplicNum} = {(num * multiplicNum)}");
            }
        }
    }
}
