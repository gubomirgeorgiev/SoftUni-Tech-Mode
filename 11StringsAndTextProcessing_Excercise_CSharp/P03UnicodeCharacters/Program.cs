using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i =0; i < input.Length; i++)
            {
                Console.Write($"\\u00{((int)input[i]).ToString("x")}");
            }
        }
    }
}
