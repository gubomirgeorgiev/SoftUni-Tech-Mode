using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09ExtractMiddleElements
{
    class Program
    {
        static void GetMiddleElements (int [] arr)
        {
            if (arr.Length == 1)
            {
                Console.WriteLine($"{{ {arr[0]} }}");
            }
            else if (arr.Length == 2)
            {
                Console.WriteLine($"{{ {arr[0]}, {arr[1]} }}");
            }
            else if (arr.Length == 3)
            {
                Console.WriteLine($"{{ {arr[0]}, {arr[1]}, {arr[2]} }}");
            }
            else if (arr.Length % 2 == 0)
            {
                Console.WriteLine($"{{ {arr[(int)Math.Floor((double)(arr.Length / 2) - 1)]}, {arr[(int)Math.Floor((double)(arr.Length / 2))]} }}");
            }
            else if (arr.Length % 2 != 0)
            {
                Console.WriteLine($"{{ {arr[(arr.Length / 2) - 1]}, {arr[arr.Length / 2]}, {arr[(arr.Length / 2) + 1]} }}");
            }
        }
        static void Main(string[] args)
        {
            int [] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            GetMiddleElements(input);
        }
    }
}
