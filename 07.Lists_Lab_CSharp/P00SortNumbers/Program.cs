using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P00SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputline = Console.ReadLine();

            List<string> items = inputline.Split(' ').ToList();
            List<int> numbers = new List<int>();
            foreach (var item in items)
            {
                numbers.Add(int.Parse(item));
            }
            numbers.Sort();
            string joint = string.Join(" ", numbers);
            Console.WriteLine(joint);
        }
    }
}
