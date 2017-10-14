using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 1; i < items.Count; i++)
            {
                if (items[i]== items[i - 1])
                {
                    items[i - 1] = items[i] + items[i];
                    items.RemoveAt(i);
                    i = 0;
                }
            }
            Console.WriteLine(string.Join(" ", items));
        }
    }
}
