using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double elevatorsCapacity = double.Parse(Console.ReadLine());
            double courses = Math.Ceiling(numberOfPeople / elevatorsCapacity);
            Console.WriteLine((int)courses);
        }
    }
}
