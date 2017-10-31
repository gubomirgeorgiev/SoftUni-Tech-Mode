using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string one = input.Split().First();
            string two = input.Split().Skip(1).First();
            long stringSum = 0;
            if (one.Length.CompareTo(two.Length) > 0)
            {
                for (int i=0; i<two.Length; i++)
                {
                    stringSum += one[i] * two[i];
                }
                for (int j= two.Length;j< one.Length; j++)
                {
                    stringSum += one[j];
                }
            }
            else if(one.Length.CompareTo(two.Length) < 0)
            {
                for (int i = 0; i < one.Length; i++)
                {
                    stringSum += one[i] * two[i];
                }
                for (int j = one.Length; j < two.Length; j++)
                {
                    stringSum += two[j];
                }
            }
            else
            {
                for (int i = 0; i < two.Length; i++)
                {
                    stringSum += one[i] * two[i];
                }
            }
            Console.WriteLine(stringSum);
        }
    }
}
