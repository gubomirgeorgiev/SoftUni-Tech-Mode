using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int) (years * 365.2422);
            long hours = (days * 24);
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong miliseconds = (ulong)(seconds * 1000);
            ulong microseconds = (miliseconds * 1000);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} " +
                $"minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {microseconds}{0}{0}{0} nanoseconds");
        }
    }
}
