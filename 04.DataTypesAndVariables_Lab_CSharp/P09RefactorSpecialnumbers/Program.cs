using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09RefactorSpecialnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            for (int num = 1; num <= lenght; num++)
            {
                int sumOfDigits = 0;
                int digit = num;
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }
                bool result = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{num} -> {result}");
            }
        }
    }
}
