using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NAKOV
namespace _01SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;
            for (int i =0; i<n; i++)
            {
                decimal price = ReadOrderAndCalculatePrice();
                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }

        private static decimal ReadOrderAndCalculatePrice()
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            string dateStr = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateStr, "d/M/yyyy", CultureInfo.InvariantCulture);
            decimal daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

            decimal capsuleCaunt = decimal.Parse(Console.ReadLine());

            decimal price = (daysInMonth * capsuleCaunt) * pricePerCapsule;
            Console.WriteLine($"The price of the coffee is: ${price:F2}");
            return price;
        }
    }
}
