using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = Console.ReadLine().ToCharArray();
            foreach(char s in array)
            {
                Console.WriteLine(s+ " -> "+ (((int)s)-97));
            }
        }
    }
}
