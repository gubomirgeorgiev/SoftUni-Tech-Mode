using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PrintingTriangle
{
    class Program
    {
        static void trinagleLines (int start, int end)
        {
            for (int i = start; i<=end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i<=input; i++)
            {
                trinagleLines(1, i);
            }
            for (int i = input-1; i>=0; i--)
            {
                trinagleLines(1, i);
            }
        }
    }
}
