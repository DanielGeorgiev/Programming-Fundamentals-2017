using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine();
        var matches = Regex.Matches(numbers, @"(^|(?<=\s))-?[0-9]+(\.[0-9]+)?($|(?=\s))");

        foreach (var match in matches)
        {
            Console.Write("{0} ", match);
        }
    }
}

