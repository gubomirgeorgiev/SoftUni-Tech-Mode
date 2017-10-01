using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {firstName} {lastName}.\n\rYou are {age} years old.");
        }
    }
}
