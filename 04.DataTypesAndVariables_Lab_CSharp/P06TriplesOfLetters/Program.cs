using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            StringBuilder output = new StringBuilder();
            for (int firstChar=97; firstChar <= 96+input; firstChar++)
            {
                for (int secondChar = 97; secondChar <= 96+input; secondChar++)
                {
                    for (int lastChar = 97; lastChar <= 96+input; lastChar++)
                    {
                        output.AppendLine(String.Format("{0}{1}{2}", (char)firstChar, (char)secondChar, (char)lastChar));
                    }
                }
            }
            Console.WriteLine(output);
        }
    }
}
