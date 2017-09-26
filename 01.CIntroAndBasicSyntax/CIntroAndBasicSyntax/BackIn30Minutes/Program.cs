using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            int totalInMinutes = (hours * 60) + minutes;
            int output = totalInMinutes+30;
            if (output >= 1440)
            {
                Console.WriteLine($"0:{(output-1440):D2}");
            }
            else
            {
                Console.WriteLine($"{(output/60):D1}:{(output%60):D2}");
            }
        }
    }
}
