using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08CondenseArrayToNumber
{
    class Program
    {
        static int GetArrayCondesedToASingleInteger (int [] arr)
        {
            int[] arrCopy = arr;
            int output = 0;
            int counte = arr.Length;
            int[] condenseArr = new int[arrCopy.Length];
            while (counte > 1)
            {
                for (int j = 0; j < arrCopy.Length-1; j++)
                {
                        condenseArr[j] = arrCopy[j] + arrCopy[j + 1];                
                }
                arrCopy = condenseArr;
                counte--;
            }
            return output = arrCopy[0];
        }
        static void Main(string[] args)
        {
            int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (input.Length == 1)
            {
                Console.WriteLine(input[0] +" is already condensed to number");
            }
            else
            {
                Console.WriteLine(GetArrayCondesedToASingleInteger(input));
            }
        }
    }
}
