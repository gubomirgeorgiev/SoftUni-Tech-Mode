using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P02ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int baseN = int.Parse(input.Split().First());
            string num = input.Split().Skip(1).First();
            int numLenght = input.Split().Skip(1).First().Length;
            int numPosition = numLenght;
            BigInteger resultBaseNNum = new BigInteger();
            for (int i = 0; i < numLenght; i++)
            {
                BigInteger numAtPosition = new BigInteger();
                numAtPosition = BigInteger.Multiply(BigInteger.Parse(num[numPosition - 1].ToString()), BigInteger.Pow(baseN, i));
                resultBaseNNum = BigInteger.Add(resultBaseNNum, numAtPosition);
                numPosition--;
            }
            Console.WriteLine(resultBaseNNum);
        }
    }
}
