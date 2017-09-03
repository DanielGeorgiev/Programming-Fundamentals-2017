using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MatchDates
{
    public static void Main()
    {
        string dates = Console.ReadLine();
        var matches = Regex.Matches(dates, @"\b(?<dayOfMonth>\d{2})(\/|\.|\-)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b");

        foreach (Match date in matches)
        {
            Console.WriteLine("Day: {0}, Month: {1}, Year: {2}", date.Groups["dayOfMonth"].Value, date.Groups["month"].Value, date.Groups["year"].Value);
        }
    }
}

