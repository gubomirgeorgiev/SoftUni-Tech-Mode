using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(x => int.Parse(new String(x.Reverse().ToArray()))).ToList();
            int sum = 0;
            foreach(int num in input)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }
    }
}
