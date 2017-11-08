using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([A-Z]{2})([0-9]+.[0-9]+){1}([a-zA-Z]+\|){1}";
            Regex regex = new Regex(pattern);
            Dictionary<string, string> citiesWeather = new Dictionary<string, string>();
            Dictionary<string, double> citiesTemperature = new Dictionary<string, double>();
            Match match = regex.Match("");
            while (input != "end")
            {
                match = regex.Match(input);
                if (match.Success)
                {
                    string matchToAdd = match.Value.Trim('|');
                    string city = matchToAdd.Substring(0, 2);
                    string numPattern = "([\\d]+.[\\d]*)";
                    Regex tempRegex = new Regex(numPattern);
                    Match numMatch = tempRegex.Match(matchToAdd);
                    double temp = double.Parse(numMatch.Value);
                    string weather = matchToAdd.Substring(numMatch.Length + 2);
                    citiesWeather[city] = weather;
                    citiesTemperature[city] = temp;
                }
                input = Console.ReadLine();
            }
            Dictionary<string, double> sortedCitiesTemperature = citiesTemperature.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (string city in sortedCitiesTemperature.Keys)
            {
                Console.WriteLine($"{city} => {sortedCitiesTemperature[city]:F2} => {citiesWeather[city]}");
            }
        }
    }
}
