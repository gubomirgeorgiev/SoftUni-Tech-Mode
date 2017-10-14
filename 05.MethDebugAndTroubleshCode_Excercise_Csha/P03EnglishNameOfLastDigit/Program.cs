using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03EnglishNameOfLastDigit
{
    class Program
    {
        static void GetLastDigitName (string num)
        {
            string lastDigit = num[num.Length-1].ToString();
            switch (lastDigit)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                case "1":
                    Console.WriteLine("one");
                    break;
            }
        }

        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            GetLastDigitName(inputNum);
        }
    }
}
