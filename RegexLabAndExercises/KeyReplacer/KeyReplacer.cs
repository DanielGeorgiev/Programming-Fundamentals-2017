using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        var keyString = Console.ReadLine();
        var textString = Console.ReadLine();
        var firstKey = Regex.Match(keyString, @"^\w+");
        var secondKey = Regex.Match(keyString, @"\w+$");
        var matches = Regex.Matches(textString, @"((?<=" + firstKey.Value + ")).*?((?=" + secondKey.Value + "))");

        var result = new StringBuilder();

        foreach (Match match in matches)
        {
            result.Append(match.Value);
        }

        if (result.Length != 0)
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Empty result");
        }
    }
}

