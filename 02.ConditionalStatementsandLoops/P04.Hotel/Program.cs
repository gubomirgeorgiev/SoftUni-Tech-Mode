using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            double nights = 1;
            nights = int.Parse(Console.ReadLine());
            switch (month)
            {
                case "May": case "October":
                    if (nights > 7)
                    {
                        if (month.Equals("October"))
                        {
                            double freeDay = nights;
                            freeDay--;
                            Console.WriteLine($"Studio: {(50 * 0.95 * freeDay):F2} lv.");
                        }
                        else
                        {
                            Console.WriteLine($"Studio: {(50 * 0.95 * nights):F2} lv.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {(50 * nights):F2} lv.");
                    }
                    Console.WriteLine($"Double: {(65 * nights):F2} lv.");
                    Console.WriteLine($"Suite: {(75 * nights):F2} lv.");
                    break;
                case "June": case "September":
                    if (month.Equals("September") && nights > 7)
                    {
                        double freeDay = nights;
                        freeDay--;
                        Console.WriteLine($"Studio: {(60 * freeDay):F2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"Studio: {(60 * nights):F2} lv.");
                    }
                    if (nights > 14)
                    {                        
                        Console.WriteLine($"Double: {(72 * 0.9 * nights):F2} lv.");
                    }
                    else
                    {                       
                        Console.WriteLine($"Double: {(72 * nights):F2} lv.");                        
                    }                                       
                    Console.WriteLine($"Suite: {(82 * nights):F2} lv.");
                    break;
                case "July": case "August": case "December":
                    Console.WriteLine($"Studio: {(68 * nights):F2} lv.");
                    Console.WriteLine($"Double: {(77 * nights):F2} lv.");
                    if (nights > 14)
                    {
                        Console.WriteLine($"Suite: {(89 * 0.85 * nights):F2} lv.");
                    }
                    else
                    {  
                        Console.WriteLine($"Suite: {(89 * nights):F2} lv.");
                    }
                    break;
            }
        }
    }
}
