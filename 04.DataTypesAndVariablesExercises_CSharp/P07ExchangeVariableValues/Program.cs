using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int temp;
            temp = b;
            b = a;
            Console.WriteLine($"Before:\na = {b}\nb = {temp}\nAfter:\na = {temp}\nb = {a}");
        }
    }
}
