using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int brake = 21;
            int counter=0;

            for (int i = 0;i<brake; i++)
            {
                var ingredient = Console.ReadLine();
                if (ingredient.Equals("Bake!"))
                {
                    brake = 0;
                    Console.WriteLine($"Preparing cake with {counter} ingredients.");
                }
                else
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }               
            }
        }
    }
}
