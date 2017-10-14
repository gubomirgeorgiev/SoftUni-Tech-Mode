using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08_GreaterOfTwoValues
{
    class Program
    {
        static int GetMax (int first, int second)
        {
            int maxValue = Math.Max(first, second);
            return maxValue;
        }
        static char GetMax (char first, char second)
        {
            int maxValue = Math.Max(Convert.ToInt32(first), Convert.ToInt32(second));
            return Convert.ToChar(maxValue);
        }
        static string GetMax (string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            else if (first.CompareTo(second) <= 0)
            {
                return second;
            }
            else return "equal";
        }
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            if (inputType.Equals("int"))
            {
                int firstInput = int.Parse(Console.ReadLine());
                int secondInput = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else if (inputType.Equals("char"))
            {
                char firstInput = char.Parse(Console.ReadLine());
                char secondInput = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
            else
            {
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                Console.WriteLine(GetMax(firstInput, secondInput));
            }
        }
    }
}
