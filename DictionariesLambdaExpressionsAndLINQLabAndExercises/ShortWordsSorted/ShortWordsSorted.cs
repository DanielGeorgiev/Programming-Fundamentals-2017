using System;
using System.Collections.Generic;
using System.Linq;
public class ShortWordsSorted
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .ToLower()
            .Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\\', '/', '!', '?', '\'', ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(x => x.Length < 5)
            .OrderBy(x => x)
            .Distinct()
            .ToList();

        Console.WriteLine(string.Join(", ", words));
    }
}

