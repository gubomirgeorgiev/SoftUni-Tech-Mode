using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace P01ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int baseN = int.Parse(input.Split().First());
            BigInteger num = BigInteger.Parse(input.Split().Skip(1).First());
            StringBuilder digits = new StringBuilder();
            digits.Append("0123456789");
            StringBuilder resultBaseNNum = new StringBuilder();
            while (num > 0)
            {
                resultBaseNNum.Insert(0,digits[(int)(num%baseN)]);
                num = num / baseN;
            }
            Console.WriteLine(resultBaseNNum);
        }
    }
}
