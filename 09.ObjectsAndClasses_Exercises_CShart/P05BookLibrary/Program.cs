using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public Book Books { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        //public DateTime Date { get { return Date; } set { Date = DateTime.ParseExact(Date.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture); } }
        public DateTime Date { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Library> libraryDB = new List<Library>();
            for (int i=0; i < num; i++)
            {
                libraryDB.Add(BookInfo());
            }
            Dictionary<string, double> output = new Dictionary<string, double>();
            foreach (var author in libraryDB)
            {
                if (!output.ContainsKey(author.Name))
                {
                    output[author.Name] = author.Books.Price; 
                }
                else
                {
                    output[author.Name] += author.Books.Price;
                }
            }
            output = output.Where(p => p.Value > 0).OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(p => p.Key, p => p.Value);
            foreach (KeyValuePair<string, double> author in output.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:F2}");
            }
        }

        static Library BookInfo()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Library bookInformation = new Library()
            {
                Name = input.Skip(1).First(),
                Books = new Book
                {
                    Title = input.First(),
                    Author = input.Skip(1).First(),
                    Publisher = input.Skip(2).First(),
                    Date = DateTime.ParseExact(input.Skip(3).First(), "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBNNumber = input.Skip(4).First(),
                    Price = input.Skip(5).Select(double.Parse).First()
                }
            };
            return bookInformation;
        }
    }
}
