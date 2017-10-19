using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var leftSide = arr.Take(arr.Length / 4).Reverse().ToArray();
            var rightSide = arr.Reverse().Take(arr.Length/4).ToArray();
            var  row1= leftSide.Concat(rightSide);
            var row2 = arr.Skip(arr.Length / 4).Take(2 * (arr.Length / 4)).ToArray();
            var sumArr = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
