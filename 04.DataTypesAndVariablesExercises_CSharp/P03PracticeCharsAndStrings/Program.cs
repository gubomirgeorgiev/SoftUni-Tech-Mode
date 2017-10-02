using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03PracticeCharsAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firslLine = Console.ReadLine();
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());
            char fourthlLine = char.Parse(Console.ReadLine());
            string fifthlLine = Console.ReadLine();
            Console.WriteLine($"{firslLine}\n{secondLine}\n{thirdLine}\n{fourthlLine}\n{fifthlLine}");
        }
    }
}
