using System;
using System.Collections.Generic;
using System.Linq;
public class CountSubstringOccurrences
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string word = Console.ReadLine();
        int wordOccurrences = 0;
        var searchPosition = -1;

        while (text.IndexOf(word, searchPosition + 1) != -1)
        {
            searchPosition = text.IndexOf(word, searchPosition + 1);
            wordOccurrences++;
        }

        Console.WriteLine(wordOccurrences);
    }
}

