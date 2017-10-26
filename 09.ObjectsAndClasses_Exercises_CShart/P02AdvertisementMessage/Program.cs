using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int messages = int.Parse(Console.ReadLine());
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

            for (int i=0; i < messages; i++)
            {
                Console.WriteLine($"{phrases[line.Next(phrases.Length)]} {events[line.Next(events.Length)]} {authors[line.Next(authors.Length)]} - {cities[line.Next(cities.Length)]}");
            }
        }
    }
}
