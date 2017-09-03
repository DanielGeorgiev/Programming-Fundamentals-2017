using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class ExtractSentencesByKeyword
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        var matches = Regex.Matches(text, @"[^.!?]*\b" + word + @"\b[^.!?]*");

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value.Trim());
        }
    }
}

