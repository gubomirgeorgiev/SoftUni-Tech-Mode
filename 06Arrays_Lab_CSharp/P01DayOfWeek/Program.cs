using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01DayOfWeek
{
    class Program
    {

        static string GetTheDayName (int days)
        {
            string[] daysOfWeek = {"","monday","tuesday","wednesday","thursday","friday","saturday","sunday"};
            return daysOfWeek[days];

        }
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            if (day >= 1 && day <= 7)
            {
                Console.WriteLine(GetTheDayName(day));
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
