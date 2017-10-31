using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10BookLibraryModification
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
        static Library BookInfo(string inputFromFile)
        {
            string[] input = inputFromFile.Split(' ').ToArray();
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
            string[] input = File.ReadAllLines("../../input.txt");
            string outputPath = "../../output.txt";
            File.Delete(outputPath);
            int num = int.Parse(input[0]);
            int dateResult = -1;
            int counter = 0;
            DateTime givenDate = new DateTime();
            List<Library> libraryDB = new List<Library>();
            while (num-- > 0)
            {
                counter++;
                libraryDB.Add(BookInfo(input[counter]));

            }
            while (num-- == -1)
            {
                counter++;
                givenDate = DateTime.ParseExact(input[counter], "dd.MM.yyyy", CultureInfo.InvariantCulture);

            }
            Dictionary<string, DateTime> output = new Dictionary<string, DateTime>();
            foreach (var author in libraryDB)
            {
                if (!output.ContainsKey(author.Name))
                {
                    dateResult = DateTime.Compare(author.Books.Date, givenDate);
                    if (dateResult > 0)
                    {
                        output.Add(author.Books.Title, author.Books.Date);
                    }
                }
                else
                {
                    dateResult = DateTime.Compare(author.Books.Date, givenDate);
                    if (dateResult > 0)
                    {
                        output[author.Books.Title] = author.Books.Date;
                    }
                }
            }
            foreach (var author in output.Where(x => x.Value > givenDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                File.AppendAllText(outputPath, ($"{author.Key} -> {author.Value:dd.MM.yyyy}")+Environment.NewLine);
            }
         }
    }
}
