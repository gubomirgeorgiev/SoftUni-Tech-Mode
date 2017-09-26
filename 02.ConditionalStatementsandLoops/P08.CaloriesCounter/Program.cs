using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int brake = int.Parse(Console.ReadLine());
            int calories=0;
            for (int i = 0; i < brake; i++)
            {
                string ingredients = Console.ReadLine();
                if (ingredients.ToLower().Equals("cheese"))
                {
                    calories += 500;
                }
                else if (ingredients.ToLower().Equals("tomato sauce"))
                {
                    calories += 150;
                }
                else if (ingredients.ToLower().Equals("salami"))
                {
                    calories += 600;
                }
                else if (ingredients.ToLower().Equals("pepper"))
                {
                    calories += 50;
                }
            }
            Console.WriteLine("Total calories: "+calories);
        }
    }
}
