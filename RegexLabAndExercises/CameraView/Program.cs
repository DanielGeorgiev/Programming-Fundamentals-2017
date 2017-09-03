using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();
        var skip = numbers[0];
        var take = numbers[1];

        var line = Console.ReadLine();
        var matches = Regex.Matches(line, @"(?<=\|\<)[A-za-z0-9]*");

        var views = new List<string>();

        foreach (Match match in matches)
        {
            var m = new string(match.Value.Skip(skip).Take(take).ToArray());
            views.Add(m);
        }

        Console.WriteLine(string.Join(", ", views));
    }
}
