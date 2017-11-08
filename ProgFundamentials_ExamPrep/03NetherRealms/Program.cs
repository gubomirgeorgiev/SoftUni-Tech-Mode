using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demonsNames = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, long> demonsHealth = new SortedDictionary<string, long>();
            Dictionary<string, decimal> demonsDamage = new Dictionary<string, decimal>();
            foreach (string demon in demonsNames)
            {
                demonsHealth[demon]= GetHealth(demon);
                demonsDamage[demon] = GetDamage(demon);
            }
            foreach(string demonName in demonsHealth.Keys)
            {
                Console.WriteLine($"{demonName} - {demonsHealth[demonName]} health, " +
                    $"{demonsDamage[demonName]:F2} damage");
            }
        }

        private static long GetHealth(string demon)
        {
            List<int> collectNums = new List<int>();
            string patternForDigits = "\\+*\\-*\\d+\\.*\\d*";
            string patternForOperators = @"\**\\*\/*";
            char[] arithmeticSymbols = { '+', '-', '*', '/', '.' };
            long health =0;
            StringBuilder symbolsCollection = new StringBuilder();
            StringBuilder opperCollection = new StringBuilder();
            var matchCharsAndOperators = Regex.Split(demon, patternForDigits);
            foreach (var matches in matchCharsAndOperators)
            {
                var matchChars = Regex.Split(matches, patternForOperators);
                var matchOperators = Regex.Matches(matches, patternForOperators);
                foreach (var symbols in matchChars.Where(x=>x!=""))
                {
                    if (!arithmeticSymbols.Contains(char.Parse(symbols)))
                    {
                        symbolsCollection.Append(symbols);
                    }
                    
                }
            }
            foreach(char symbole in symbolsCollection.ToString())
            {
                health += (long)symbole;
            }
            return health;
        }


        private static decimal GetDamage(string demon)
        {
            List<decimal> collectNums = new List<decimal>();
            string numbers = "\\+*\\-*\\d+\\.*\\d*";
            string patternForOperators = @"\**\\*";
            StringBuilder opperCollection = new StringBuilder();
            
            foreach (Match digit in Regex.Matches(demon, numbers))
            {
                collectNums.Add(decimal.Parse(digit.Value.ToString()));
            }
            decimal damage = 0;
            foreach(Match opp in Regex.Matches(demon, patternForOperators))
        {
                opperCollection.Append(opp.Value);
            }
            foreach (decimal num in collectNums)
            {
                damage += num;
            }
            foreach(char charOperator in opperCollection.ToString())
            {
                if (charOperator == '*')
                {
                    damage *= 2;
                }
                else
                {
                    damage /= 2;
                }
            }
            return damage;
        }
    }
}
