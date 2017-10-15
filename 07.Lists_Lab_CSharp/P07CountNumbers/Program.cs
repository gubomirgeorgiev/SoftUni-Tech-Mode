using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            input.Sort((a, b) => a.CompareTo(b));
            var dictionary = new Dictionary<int, int>();
            int[] numsZeroToTousen = new int[1001];
            foreach (int num in input)
            {
                numsZeroToTousen[num]++;
            }
            for (int i = 0; i < numsZeroToTousen.Length; i++)
            {
                if (numsZeroToTousen[i] > 0)
                {
                    dictionary.Add(i, numsZeroToTousen[i]);
                }
            }
            Console.WriteLine(string.Join("", dictionary.Select(kvp => kvp.Key + " -> " + kvp.Value.ToString() + "\n")));
        }
    }
}
