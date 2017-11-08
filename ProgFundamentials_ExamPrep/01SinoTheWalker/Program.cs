using System;
using System.Globalization;
using System.Linq;

namespace _01SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leave = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            int numOfSteps = int.Parse(Console.ReadLine())%86400;
            int timeInSecForEachStep = int.Parse(Console.ReadLine())%86400;
            int travelTimeInSec = numOfSteps * timeInSecForEachStep;
            TimeSpan travelTime = new TimeSpan(0, 0, travelTimeInSec);
            DateTime output = leave.Add(travelTime);
            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}",output.Hour,output.Minute,output.Second);
        }
    }
}
