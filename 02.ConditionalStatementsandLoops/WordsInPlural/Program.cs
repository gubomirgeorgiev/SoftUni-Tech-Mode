using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsInPlural
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            String output="";
            int i = input.Count();
            if (input.EndsWith("y"))
            {             
                output = input.Remove(i-1,1) + "ies";            
            }
            else if (input.EndsWith("o") ||  input.EndsWith("s") ||  input.EndsWith("x") || input.EndsWith("z") || input.EndsWith("ch") || input.EndsWith("sh"))
            {
                output = input + "es";
            }
            else
            {
                output = input + "s";
            }
            Console.WriteLine(output);
        }
    }
}
