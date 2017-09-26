using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            switch (input)
            {
                case "Athlete":
                    Console.WriteLine($"The {input} has to pay {(quantity * 0.7):F2}.");
                    break;
                case "Businessman": case "Businesswoman":
                    Console.WriteLine($"The {input} has to pay {(quantity*1):F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The {input} has to pay {(quantity * 1.7):F2}.");
                    break;
                default:
                    Console.WriteLine($"The {input} has to pay {(quantity * 1.2):F2}.");
                    break;
            }
        }
    }
}
