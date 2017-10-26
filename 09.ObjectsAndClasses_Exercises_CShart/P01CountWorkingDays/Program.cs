using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondtDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDays = 0;
            bool isHoliday=false;
            DateTime[] holidays = new DateTime[]
            {
                new DateTime (2000,1,1),
                new DateTime (2000,3,3),
                new DateTime (2000,5,1),
                new DateTime (2000,5,6),
                new DateTime (2000,5,24),
                new DateTime (2000,9,6),
                new DateTime (2000,9,22),
                new DateTime (2000,11,1),
                new DateTime (2000,12,24),
                new DateTime (2000,12,25),
                new DateTime (2000,12,26)
            };

            for (DateTime start = firstDate; start<= secondtDate; start = start.AddDays(1.0))
            {
                foreach(DateTime day in holidays)
                {
                    if ((start.Day == day.Day&& start.Month == day.Month)||start.DayOfWeek==DayOfWeek.Saturday|| start.DayOfWeek==DayOfWeek.Sunday)
                    {
                        isHoliday = true;
                        
                    }
                }
                if (isHoliday != true)
                {
                    workingDays++;
                }
                isHoliday = false;
            }
            Console.WriteLine(workingDays);
        }
    }
}
