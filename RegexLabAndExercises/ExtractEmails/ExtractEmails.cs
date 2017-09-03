using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class ExtractEmails
{
    public static void Main()
    {
        var line = Console.ReadLine();
        var matches = Regex.Matches(line, @"(?<=\s)[a-z0-9]+([._-][a-z0-9]+)*@[a-z]+([.-][a-z]+)*(\.[a-z]+)");

        foreach (var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

