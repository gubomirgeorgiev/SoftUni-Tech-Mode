using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopper = 999;
            int roundhouseKick = int.Parse(Console.ReadLine());
            int thunderousFist = int.Parse(Console.ReadLine());
            int peshosHealth = 100; 
            int goshosHealth = 100;
            int odd = 1;
            int even = 3;
            int round = 0;
            for (int i=0; i < stopper; i++)
            {
                for (int j = odd; j <=even; j++)
                {            
                    if (j % 2 != 0)
                    {
                        round++;
                        goshosHealth -= roundhouseKick;
                        if (goshosHealth <= 0)
                        {
                            Console.WriteLine($"Pesho won in {round}th round.");
                            j += (even + 2);
                            stopper = 0;
                        }
                        else
                        {
                            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                        }
                    }
                    else
                    {
                        round++;
                        peshosHealth -= thunderousFist;
                        if (peshosHealth <= 0)
                        {
                            Console.WriteLine($"Gosho won in {round}th round.");
                            j += (even + 2);
                            stopper = 0;
                        }
                        else
                        {
                            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                        }
                    }
                }
                odd += 3;
                even += 3;
                peshosHealth += 10;
                goshosHealth += 10;
            }
        }
    }
}
