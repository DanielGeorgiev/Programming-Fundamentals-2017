using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
public class BookLibrary
{
    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int IsbnNumber { get; set; }

        public decimal Price { get; set; }


    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var library = new Library()
        {
            Name = "DankoHarsuzina's Library",
            Books = new List<Book>()
        };

        for (int i = 0; i < n; i++)
        {
            var tokens = Console.ReadLine()
                .Split();

            var title = tokens[0];
            var author = tokens[1];
            var publisher = tokens[2];
            var releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var isbn = int.Parse(tokens[4]);
            var price = decimal.Parse(tokens[5]);

            var book = new Book
            {
                Title = title,
                Author = author,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                IsbnNumber = isbn,
                Price = price,
            };

            library.Books.Add(book);
        }

        var line = Console.ReadLine();

        var givenDate = DateTime.ParseExact(line, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        var bookReleaseDate = new Dictionary<string, DateTime>();

        foreach (var book in library.Books)
        {
            bookReleaseDate[book.Title] = book.ReleaseDate;
        }

        bookReleaseDate = bookReleaseDate.Where(x => DateTime.Compare(x.Value, givenDate) > 0).OrderBy(date => date.Value).ThenBy(title => title.Key).ToDictionary(x => x.Key, y => y.Value);

        foreach (var book in bookReleaseDate)
        {
            Console.WriteLine("{0} -> {1}", book.Key, book.Value.ToString("dd.MM.yyy"));
        }
    }
}

