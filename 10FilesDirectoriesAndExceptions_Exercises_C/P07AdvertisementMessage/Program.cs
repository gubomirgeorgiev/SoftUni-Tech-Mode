using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] messages = File.ReadAllLines("../../input.txt").Select(int.Parse).ToArray();
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            for (int i =0; i < messages.Length; i++)
            {
                Random line = new Random();
                string[] phrases = new string[]
                {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
                };
                string[] events = new string[]
                {
                 "Now I feel good.",
                 "I have succeeded with this product.",
                 "Makes miracles. I am happy of the results!",
                 "I cannot believe but now I feel awesome.",
                 "Try it yourself, I am very satisfied.",
                 "I feel great!"
                };
                string[] authors = new string[]
                {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
                };
                string[] cities = new string[]
                {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
                };

                for (int j = 0; j < messages[i]; j++)
                {
                    File.AppendAllText(outputPath, ($"{phrases[line.Next(phrases.Length)]} {events[line.Next(events.Length)]} {authors[line.Next(authors.Length)]} - {cities[line.Next(cities.Length)]}")+Environment.NewLine);
                }
            }
        }
    }
}
