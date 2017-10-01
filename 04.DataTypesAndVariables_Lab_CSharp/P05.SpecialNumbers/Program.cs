using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i=1; i<=input; i++)
            {
                string num = i.ToString();
                int sum = 0;
                int numToInt = i;
                for (int j=0; j < num.Length; j++)
                {
                    sum += numToInt%10;
                    numToInt = numToInt / 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", i);
                }
                else
                {
                    Console.WriteLine("{0} -> False", i);
                }
            }
        }
    }
}
