using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05MagicExchangeableWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string one = input.Split().First();
            string two = input.Split().Skip(1).First();
            CheckStringsExchangable(one,two);
        }

        private static void CheckStringsExchangable(string firstInput, string secondInput)
        {
            bool exchangable=false;
            var one = firstInput.ToLower().Distinct().ToArray();
            var two = secondInput.ToLower().Distinct().ToArray();
            if (one.Count() == two.Count())
            {
                            exchangable = true;
            }
            Console.WriteLine(exchangable.ToString().ToLower());
        }
    }
}
