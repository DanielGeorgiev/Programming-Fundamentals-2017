using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MatchPhoneNumber
{
    public static void Main()
    {
        string phoneNumbers = Console.ReadLine();
        var matches = Regex.Matches(phoneNumbers, @"(\+359(-| )2)\2([0-9]{3}\2[0-9]{4})");

        var matchesArray = matches.Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToArray();

        Console.WriteLine(string.Join(", ", matchesArray));
    }
}

