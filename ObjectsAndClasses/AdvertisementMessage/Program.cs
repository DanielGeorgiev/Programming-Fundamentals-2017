using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        var phrases = new List<string>()
        {
            "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
        };

        var events = new List<string>()
        {
            "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
        };

        var authors = new List<string>()
        {
            "Diana", "Petya", "Stella", "Elena", "Katya", "Ïva", "Annie", "Eva"
        };

        var cities = new List<string>()
        {
            "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
        };

        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            var randomPhrase = rnd.Next(0, phrases.Count - 1);
            var randomEvent = rnd.Next(0, events.Count - 1);
            var randomAuthor = rnd.Next(0, phrases.Count - 1);
            var randomCity = rnd.Next(0, events.Count - 1);
            Console.WriteLine("{0} {1} {2}-{3}", phrases[randomPhrase], events[randomEvent], authors[randomAuthor], cities[randomCity]);
        }
        
        
    }
}

