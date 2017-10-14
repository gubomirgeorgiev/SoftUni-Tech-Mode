using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02RotateAndSum
{
    class Program
    {
        static int [] GetArrayRoatated (int [] arr, int rotator)
        {
            int[] arraySum = new int[arr.Length];
            int counter = 0;
            for(int rotatingCounter = 1; rotatingCounter <= rotator; rotatingCounter++)
            {

                for (int i =0; i< arr.Length; i++)
                {
                    if (rotatingCounter>= arr.Length)
                    {
                        counter++;
                        arraySum[i] += arr[(i + arr.Length+rotatingCounter) % arr.Length];
                    }else
                    arraySum[i] += arr[(i+arr.Length- rotatingCounter) % arr.Length];
                }
            }
            return arraySum;
        }
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join(" ", GetArrayRoatated(input,k)));
        }
    }
}
