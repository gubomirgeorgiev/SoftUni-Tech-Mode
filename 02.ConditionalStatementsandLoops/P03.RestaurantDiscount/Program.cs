using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = double.Parse(Console.ReadLine());
            var package = Console.ReadLine();
            if (groupSize > 0 && groupSize <= 120)
            {
                switch (package)
                {
                    case "Normal":
                        if (groupSize <= 50)
                        {
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(((2500 + 500) - (2500 + 500) * 0.05) / groupSize):F2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(((5000 + 500) - (5000 + 500) * 0.05) / groupSize):F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(((7500 + 500) - (7500 + 500) * 0.05) / groupSize):F2}$");
                        }
                        break;
                    case "Gold":
                        if (groupSize <= 50)
                        {
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(((2500 + 750) - (2500 + 750) * 0.1) / groupSize):F2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(((5000 + 750) - (5000 + 750) * 0.1) / groupSize):F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(((7500 + 750) - (7500 + 750) * 0.1) / groupSize):F2}$");
                        }
                        break;
                    case "Platinum":
                        if (groupSize <= 50)
                        {
                            Console.WriteLine("We can offer you the Small Hall");
                            Console.WriteLine($"The price per person is {(((2500 + 1000) - (2500 + 1000) * 0.15) / groupSize):F2}$");
                        }
                        else if (groupSize > 50 && groupSize <= 100)
                        {
                            Console.WriteLine("We can offer you the Terrace");
                            Console.WriteLine($"The price per person is {(((5000 + 1000) - (5000 + 1000) * 0.15) / groupSize):F2}$");
                        }
                        else
                        {
                            Console.WriteLine("We can offer you the Great Hall");
                            Console.WriteLine($"The price per person is {(((7500 + 1000) - (7500 + 1000) * 0.15) / groupSize):F2}$");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }           
        }
    }
}
