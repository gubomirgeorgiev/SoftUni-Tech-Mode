using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01PracticeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte firstNum = SByte.Parse(Console.ReadLine());
            Byte secondNum = Byte.Parse(Console.ReadLine());
            short thirdNum = short.Parse(Console.ReadLine());
            ushort forthNum = ushort.Parse(Console.ReadLine());
            uint fifthNum = uint.Parse(Console.ReadLine());
            int sixtNum = int.Parse(Console.ReadLine());
            long seventhNum = long.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNum}\n{secondNum}\n{thirdNum}\n{forthNum}\n{fifthNum}\n{sixtNum}\n" +
                $"{seventhNum}");
        }
    }
}
