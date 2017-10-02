using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput = Console.ReadLine();
            bool stringOrNot = Convert.ToBoolean(stringInput);
            if (stringOrNot == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }           
        }
    }
}
