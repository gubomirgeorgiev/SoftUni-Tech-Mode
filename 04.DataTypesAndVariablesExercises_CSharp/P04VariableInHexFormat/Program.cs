using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexadecimalFormatInput = Console.ReadLine();
            int inputConvertedToDecimalFormat = Convert.ToInt16(hexadecimalFormatInput, 16);
            Console.WriteLine(inputConvertedToDecimalFormat);
        }
    }
}
