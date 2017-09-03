using System;
using System.Collections.Generic;
using System.Linq;
public class OddOccurrences
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var wordAndOccurrences = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (wordAndOccurrences.ContainsKey(word))
            {
                wordAndOccurrences[word]++;
            }
            else
            {
                wordAndOccurrences[word] = 1;
            }
        }

        var occurrences = new List<string>();

        foreach (var item in wordAndOccurrences)
        {
            if (item.Value % 2 != 0)
            {
                occurrences.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ", occurrences));
    }
}
