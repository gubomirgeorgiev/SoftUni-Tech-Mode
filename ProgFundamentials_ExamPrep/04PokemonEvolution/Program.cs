using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PokemonEvolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Pokemon> evolutionList = new List<Pokemon>();
            while (!input.Equals("wubbalubbadubdub"))
            {
                if(input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray().Length == 1)
                {
                    string pName = input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).First();
                    if (evolutionList.Any(a=>a.PokemonName == pName))
                    {
                        GetPokemonPrinted(pName, evolutionList);
                    }
                }
                else
                {
                    string pokemoName = input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).First();
                    string evolutionType = input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).Skip(1).First();
                    long evolutionIndex = long.Parse(input.Split(new char[] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries).Skip(2).First());
                    if (evolutionList.Any(a => a.PokemonName == pokemoName))
                    {
                        evolutionList.First(a => a.PokemonName == pokemoName).PEvolution.Add(new Evolution()
                        {
                            EvolutionType = evolutionType,
                            EvolutionIndex = evolutionIndex
                        });
                    }
                    else
                    {
                        evolutionList.Add(new Pokemon()
                        {
                            PokemonName = pokemoName,
                            PEvolution = new List<Evolution>()
                        {
                           new Evolution()
                           {
                               EvolutionType=evolutionType,
                               EvolutionIndex=evolutionIndex
                           }
                        }
                        });
                    }
                }
                input = Console.ReadLine();
            }
            GetOutputPrinted(evolutionList);
        }

        private static void GetOutputPrinted(List<Pokemon> evolutionList)
        {
            foreach (string pokemonName in evolutionList.Select(a=>a.PokemonName))
            {
                Console.WriteLine($"# {pokemonName}");
                foreach(var evolution in evolutionList.First(a => a.PokemonName == pokemonName).PEvolution.OrderByDescending(x => x.EvolutionIndex))
                {
                    Console.WriteLine($"{string.Join(Environment.NewLine, evolution.EvolutionType + " <-> " + evolution.EvolutionIndex)}");
                }
            }
        }

        private static void GetPokemonPrinted(string pName, List<Pokemon> evolutionList)
        {
            Console.WriteLine($"# {pName}");
            foreach (var evolution in evolutionList.First(a=>a.PokemonName==pName).PEvolution)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, evolution.EvolutionType + " <-> "+ evolution.EvolutionIndex)}");
            }
        }

        class Pokemon
        {
            public string PokemonName { get; set; }
            public List<Evolution> PEvolution { get; set; }
            
        }
        public class Evolution
        {
            public string EvolutionType { get; set; }
            public long EvolutionIndex { get; set; }
        }
    }
}
