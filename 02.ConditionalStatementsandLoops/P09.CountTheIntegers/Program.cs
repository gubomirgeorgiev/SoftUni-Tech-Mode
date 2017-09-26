using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
           int counter = 0;
           int breaker = 100;
            for (int i = 0; i < breaker; i++)
            {
                try
                {
                    var input = Console.ReadLine();
                    int.Parse(input);
                    counter++;
                }
                catch (Exception e)
                {
                    breaker = 0;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
