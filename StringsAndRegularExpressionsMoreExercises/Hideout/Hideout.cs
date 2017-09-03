using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Hideout
{
    public static void Main()
    {
        bool hideoutFound = false;

        var map = Console.ReadLine();

        while (!hideoutFound)
        {
            var clues = Console.ReadLine()
                .Split();
            var hideout = clues[0];
            var minLength = clues[1];
            var regex = new Regex("\\" + hideout + "{" + minLength + ",}");

            if (regex.IsMatch(map))
            {
                var match = regex.Match(map);
                var index = match.Index;
                var length = match.Length;
                Console.WriteLine("Hideout found at index {0} and it is with size {1}!", index, length);
                hideoutFound = true;
            }
        }
    }
}