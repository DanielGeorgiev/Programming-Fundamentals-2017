using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var words = Console.ReadLine().ToLower().Split().ToArray();

        var wordsOccurrences = new SortedDictionary<string, int>();
        foreach (var word in words)
            wordsOccurrences[word] = 0;
        foreach (var word in words)
            wordsOccurrences[word]++;

        var outputWords = new List<string>();

        foreach (var item in wordsOccurrences)
        {
            if (item.Value % 2 != 0)
            {
                outputWords.Add(item.Key);
            }
        }

        Console.WriteLine(string.Join(", ", outputWords));
    }
}

