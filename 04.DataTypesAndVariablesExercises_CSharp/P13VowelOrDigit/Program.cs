using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());
            string vowel = "aeiouy";
                if (vowel.Contains(symbol))
                {
                    Console.WriteLine("vowel");
            }
            else
            {
                try
                {
                    int symbolIsNumber = int.Parse(symbol.ToString());
                    Console.WriteLine("digit");
                }
                catch (Exception e)
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
