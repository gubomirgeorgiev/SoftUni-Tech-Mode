using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var beverageName = Console.ReadLine();
            double beverageVolume = double.Parse(Console.ReadLine());
            double energyContentPer100Ml = double.Parse(Console.ReadLine());
            double sugarContentPer100Ml = double.Parse(Console.ReadLine());
            Console.WriteLine($"{beverageVolume}ml {beverageName}:");
            Console.WriteLine($"{(beverageVolume/100)* energyContentPer100Ml}kcal, {(beverageVolume / 100) * sugarContentPer100Ml}g sugars");
        }
    }
}
