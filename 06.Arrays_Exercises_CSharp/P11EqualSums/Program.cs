using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            var index = -1;
            var array = (string.Join("", Console.ReadLine())).Split().Select(int.Parse).ToArray();
                for (int i = 0; i < array.Length; i++)
                {
                    var leftSum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += array[j];
                    }
                    var rightSume = 0;
                    for (int p = array.Length - 1; p > i; p--)
                    {
                        rightSume += array[p];
                    }
                    if (leftSum == rightSume)
                    {
                        index = i;
                    }
                }
            if (index==-1)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
