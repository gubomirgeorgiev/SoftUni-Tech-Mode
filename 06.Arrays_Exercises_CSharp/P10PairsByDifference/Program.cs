using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10PairsByDifference
{
    class Program
    {

        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split( ).Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());
            var counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[i] - array[j] == difference || array[j] - array[i] == difference)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
