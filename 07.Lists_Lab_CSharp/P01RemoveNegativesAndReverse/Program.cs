using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputline = Console.ReadLine();
            List<string> items = inputline.Split(' ').ToList();
            List<int> squares = new List<int>();
            foreach (var item in items)
            {
                if (int.Parse(item) >= 0)
                {
                    squares.Add(int.Parse(item));
                }
            }
            if (squares.Count() == 0)
            {
                Console.WriteLine("empty");
            }
            squares.Reverse();
            Console.WriteLine(string.Join(" ", squares));
        }
    }
}
