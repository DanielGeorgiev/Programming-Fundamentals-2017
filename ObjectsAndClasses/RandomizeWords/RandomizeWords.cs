using System;
using System.Collections.Generic;
using System.Linq;
public class RandomizeWords
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split()
            .ToList();
        var randomizeWords = new Random();

        for (int i = 0; i <= words.Count - 1; i++)
        {
            var wordIndex = randomizeWords.Next(i, words.Count-1);
            words[i] = words[wordIndex];
            Console.WriteLine(words[i]);
        }
    }
}

