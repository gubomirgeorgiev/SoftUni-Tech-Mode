using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace P01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dayOfWeek = DateTime.ParseExact(Console.ReadLine(),"d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
