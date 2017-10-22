using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int salesNum = int.Parse(Console.ReadLine());
            List<Sale> totalSales = new List<Sale>();
            for (int i =0; i<salesNum; i++)
            {
                totalSales.Add(ReadSale());
            }
            var towns = totalSales.Select(s => s.Town).Distinct().OrderBy(t => t);
            foreach (string town in towns)
            {
                var salesByTown = totalSales.Where(s => s.Town == town)
                 .Select(s => s.Price * s.Quantity);
                Console.WriteLine("{0} -> {1:f2}", town, salesByTown.Sum());
            }

        }

        public static Sale ReadSale ()
        {
            var saleData = Console.ReadLine();
            Sale data = new Sale()
            {
                Town = saleData.Split().First(),
                Product = saleData.Split().Skip(1).First(),
                Price = saleData.Split().Skip(2).Select(decimal.Parse).First(),
                Quantity = saleData.Split().Skip(3).Select(decimal.Parse).First()
            };
            return data;
        }
    }
}
