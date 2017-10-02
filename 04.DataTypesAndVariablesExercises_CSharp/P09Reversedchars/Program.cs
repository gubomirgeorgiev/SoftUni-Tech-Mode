using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09Reversedchars
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<char> chars = new Queue<char>();
            chars.Enqueue(char.Parse(Console.ReadLine()));
            chars.Enqueue(char.Parse(Console.ReadLine()));
            chars.Enqueue(char.Parse(Console.ReadLine()));
            IEnumerable reversed = chars.Reverse();
            foreach (char result in reversed)
            {
                Console.Write(result);
            }
        }
    }
}
