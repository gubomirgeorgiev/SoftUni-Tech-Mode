using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            int numb1=0;
            int numb2 = 0;
            for (int i=N; i<=M; i++)
            {
                for (int j = N; j<=M; j++)
                {
                    counter++;
                        if (i + j == magicNumber)
                        {
                            numb1 = j;
                            numb2 = i;
                        }               
                }
            }
            if (numb1 != 0)
            {
                Console.WriteLine($"Number found! {numb2} + {numb1} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
