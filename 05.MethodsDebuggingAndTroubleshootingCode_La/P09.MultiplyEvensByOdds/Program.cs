using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.MultiplyEvensByOdds
{
    class Program
    {
        static int GetSumOfEvens (int events)
        {
            int sumEvens = 0;
            while (events > 0)
            {
                int lastdigit = events % 10;
                if (lastdigit % 2 == 0)
                {
                    sumEvens += events%10;
                }
                events /= 10;
            }
            return sumEvens;
        }
        static int GetSumOfOdds(int events)
        {
            int sumOdds = 0;
            while (events > 0)
            {
                int lastdigit = events % 10;
                if (lastdigit % 2 != 0)
                {
                    sumOdds += events % 10; 
                }
                events /= 10;
            }
            return sumOdds;
        }
        static int GetMultipleOfEvensAndOdds (int n)
        {
            int sumEvens = GetSumOfEvens(n);
            int sumOdds = GetSumOfOdds(n);
            return sumEvens * sumOdds;
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(Math.Abs(input)));
        }
    }
}
