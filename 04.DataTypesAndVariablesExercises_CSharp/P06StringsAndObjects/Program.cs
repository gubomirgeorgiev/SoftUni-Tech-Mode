using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloStr = "Hello";
            string worldStr = "World";
            object concatenateStringsinObject = helloStr + " " + worldStr;
            string result = (string)concatenateStringsinObject;
            Console.WriteLine(result);
        }
    }
}
