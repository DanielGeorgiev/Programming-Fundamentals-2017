using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Mines
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var explosionRangeMatches = Regex.Matches(input, @"(?<=<)[a-zA-z0-9]+(?=>)");

        foreach (Match m in explosionRangeMatches)
        {
            var explosionRange = Math.Abs(m.Value[0] - m.Value[1]);
            input = Regex.Replace(input, @".{0," + explosionRange + "}<[a-zA-z0-9]+>[a-zA-z0-9]{0," + explosionRange + "}", new string('_', 4 + explosionRange * 2));
        }
        
        Console.WriteLine(input);
    }
}
