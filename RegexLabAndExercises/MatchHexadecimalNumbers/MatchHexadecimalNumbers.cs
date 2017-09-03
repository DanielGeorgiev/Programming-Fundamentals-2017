using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MatchHexadecimalNumbers
{
    public static void Main()
    {
        string input = Console.ReadLine();
        var matches = Regex.Matches(input, @"\b(?:0x)?[A-F0-9]+\b");
        var matchesArray = matches
            .Cast<Match>()
            .Select(a => a.Value)
            .ToArray();

        Console.WriteLine(string.Join(" ", matchesArray));
    }
}

