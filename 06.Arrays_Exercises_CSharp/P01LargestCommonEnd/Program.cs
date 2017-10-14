using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01LargestCommonEnd
{
    class Program
    {
        static int GetLargestCommonEnd (string[] firstArr, string[] secondArr)
        {
            int leftCounter = 0;
            int rightCounter = 0;
            int lenghtDifference = Math.Max(firstArr.Length, secondArr.Length) - Math.Min(firstArr.Length, secondArr.Length);
            for (int i=0; i<Math.Min(firstArr.Length,secondArr.Length); i++)
            {
                if (firstArr[i]==secondArr[i]&& leftCounter==i)
                {
                    leftCounter++;                    
                }
            }
            for (int j = Math.Min(firstArr.Length, secondArr.Length)-1; j>= 0; j--)
            {
                if (firstArr.Length> secondArr.Length)
                {
                    if (firstArr[j+ lenghtDifference].Equals(secondArr[j])&& rightCounter==(Math.Min(firstArr.Length, secondArr.Length) - 1)-j)
                    {
                        rightCounter++;
                    }
                }
                else if (firstArr.Length < secondArr.Length)
                {
                    if (firstArr[j].Equals(secondArr[j + lenghtDifference])&& rightCounter == (Math.Min(firstArr.Length, secondArr.Length) - 1) - j)
                    {
                        rightCounter++;
                    }
                }
                else
                {
                    if (firstArr[j].Equals(secondArr[j])&& rightCounter == (Math.Min(firstArr.Length, secondArr.Length) - 1) - j)
                    {
                        rightCounter++;
                    }
                }
                
            }
            
            return (leftCounter>=rightCounter)? leftCounter: rightCounter;
        }
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');
            Console.WriteLine(GetLargestCommonEnd(firstInput, secondInput));
        }
    }
}
