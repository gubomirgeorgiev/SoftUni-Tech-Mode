using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = n;
            int forCount = 999;
            int oddCount=0;
            if (count > 0)
            {
                for (int i = 1; i <= forCount; i++)
                {
                    if (count > 0)
                    { 
                        if (i % 2 != 0)
                        {
                            Console.WriteLine(i);
                            oddCount += i;
                            count--;
                        }
                    }
                    else forCount = 0;
                }
            }
            Console.WriteLine("Sum: "+oddCount);
        }
    }
}
