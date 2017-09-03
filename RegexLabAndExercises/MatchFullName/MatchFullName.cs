using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MatchFullName
{
    public static void Main()
    {
        string names = Console.ReadLine();
        var matches = Regex.Matches(names, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

        foreach (var match in matches)
        {
            Console.Write("{0} ", match);
        }
    }
}

