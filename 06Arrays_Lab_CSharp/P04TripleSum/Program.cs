using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04TripleSum
{
    class Program
    {
        static void GetTripleSum(long[] arr, int lenght)
        {
            long[] arrCopy = arr;
            bool sumExists = false;
            long sum = 0;
            for (int AAt = 0; AAt < lenght; AAt++)
            {
                for (int BAt = AAt+1; BAt < lenght; BAt++)
                {
                    //for(int NAt= 0; NAt < lenght; NAt++)
                    //{
                        sum = arrCopy[AAt] + arrCopy[BAt];
                        if (arrCopy.Contains(sum))
                        {
                            Console.WriteLine($"{arrCopy[AAt]} + {arrCopy[BAt]} == {arrCopy[AAt]+ arrCopy[BAt]}");
                            sumExists = true;
                        }
                    //}
                }
            }
            if (sumExists == false)
            {
                Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            GetTripleSum(numbers, numbers.Length);
        }
    }
}
