using System;
using System.Text;
using System.Numerics;

namespace P07MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().TrimStart(new char[] { '0' });
            string multiplier = Console.ReadLine().TrimStart(new char[] { '0' });
            if (multiplier.Equals(""))
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(GetNumMultiplied(num, multiplier));
            } 
        }

        private static StringBuilder GetNumMultiplied(string StingToNumber, string multiplier)
        {
            StringBuilder output = new StringBuilder();
            int multiplierNum = int.Parse(multiplier);
            int numLenght = StingToNumber.Length;
            int sum = 0;
            int number = 0;
            int residual = 0;
            while (numLenght-- > 0)
            {
                sum = (int.Parse(StingToNumber[numLenght].ToString()) * multiplierNum) + number;
                number = sum / 10;
                residual = sum % 10;
                output.Insert(0, residual);
            }
            if (number > 0)
            {
                output.Insert(0, number);
            }
            return output;
        }
    }
}
