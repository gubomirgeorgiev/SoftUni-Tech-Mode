using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }).Where(s => s.Length < 5&&s!="").OrderBy(t => t).Distinct().ToList();
            Console.WriteLine(string.Join(", ", input));
        }
    }
}
