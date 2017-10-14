using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.HelloName_
{
    class Program
    {
        static string GetName (string name)
        {
            return name;
        }
        static void Main(string[] args)
        {
            String nameInput = Console.ReadLine(); 
            Console.WriteLine($"Hello, {GetName(nameInput)}!");
        }
    }
}
