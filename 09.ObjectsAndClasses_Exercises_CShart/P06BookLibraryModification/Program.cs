using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06BookLibraryModification
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
        public DateTime Date { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
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

        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int dateResult = -1;
            DateTime givenDate = new DateTime();
            List <Library> libraryDB = new List<Library>();
            while (num-- > 0)
            {
                libraryDB.Add(BookInfo());
            }
            while (num-- == -1)
            {
                givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            }
            Dictionary<string, DateTime> output = new Dictionary<string, DateTime>();
            foreach (var author in libraryDB)
            {
                if (!output.ContainsKey(author.Name))
                {
                    dateResult = DateTime.Compare(author.Books.Date, givenDate);
                        if (dateResult > 0)
                    {
                        output.Add(author.Books.Title,author.Books.Date);
                    }
                }
                else
                {
                    dateResult = DateTime.Compare(author.Books.Date, givenDate);
                    if (dateResult > 0)
                    {
                        output[author.Books.Title]=author.Books.Date;
                    }
                }
            }
            foreach (var author in output.Where(x=>x.Value> givenDate).OrderBy(x=>x.Value).ThenBy(x=>x.Key))
            {
                    Console.WriteLine($"{author.Key} -> {author.Value:dd.MM.yyyy}");
            }
        }
    }
}
