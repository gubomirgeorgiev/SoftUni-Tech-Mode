using System;
using System.Collections.Generic;
using System.Linq;

namespace P08LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new char[] { ' ', '\t'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            double tempSum = 0.0;
            double total = 0.0;
            while (input.Count > 0)
            {
                if (char.IsUpper(input[0][0]))
                {
                    tempSum = GetNumberFromString(input[0]) / GetCharPossitionNumber(input[0][0]);
                }
                else
                {
                    tempSum = GetNumberFromString(input[0]) * GetCharPossitionNumber(input[0][0]);
                }
                if (char.IsUpper(input[0][input[0].Length - 1]))
                {
                    tempSum -= GetCharPossitionNumber(input[0][input[0].Length - 1]);
                }
                else
                {
                    tempSum += GetCharPossitionNumber(input[0][input[0].Length - 1]);
                }
                input.RemoveAt(0);
                total += tempSum;
                tempSum = 0.0;
            }
            
            Console.WriteLine("{0:F2}", total);
        }

        private static double GetCharPossitionNumber(char input)
        {
            int num = 0;
            if (char.IsUpper(input))
            {
                num = input - 64;
            }
            else
            {
                num = input - 96;
            }
            return num;
        }

        private static double GetNumberFromString(string input)
        {
            int numbercounter = 1;
            int numFromString = 0;
            string number = "";
            while (int.TryParse(input[numbercounter++].ToString(), out numFromString))
            {
                number += numFromString;
            }
            return double.Parse(number);
        }
    }
}
