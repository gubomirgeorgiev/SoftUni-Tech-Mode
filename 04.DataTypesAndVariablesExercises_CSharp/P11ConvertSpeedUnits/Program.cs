using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            int timeInSeconds = (hours * 3600) + (minutes*60)+seconds;
            float speedMetersPerSecond = ((float)distanceInMeters / timeInSeconds);
            float speedKilometersPerHour = (((float)distanceInMeters / 1000) / ((float)timeInSeconds / 3600));
            float speedMilesPerHour = (((float)distanceInMeters / 1609) / ((float)timeInSeconds / 3600));
            Console.WriteLine($"{speedMetersPerSecond}\n{speedKilometersPerHour}\n{speedMilesPerHour}");
        }
    }
}
