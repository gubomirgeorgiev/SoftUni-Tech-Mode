using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            var dict = new SortedDictionary<decimal, int>();
            foreach(decimal num in input)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num]=1;
                }
            }
            Console.WriteLine( string.Join("\r\n",dict.Select(x=>x.Key + " -> "+ x.Value)));
        }
    }
}
