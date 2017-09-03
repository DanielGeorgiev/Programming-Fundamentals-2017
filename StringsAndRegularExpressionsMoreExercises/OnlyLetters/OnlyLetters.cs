using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class OnlyLetters
{
    public static void Main()
    {
        string str1 = Console.ReadLine();
        var numbers = Regex.Matches(str1, @"[0-9]+");
        var letterAfterNumbers = Regex.Matches(str1, @"(?<=[0-9])[a-zA-z]");

        for (int i = 0; i < letterAfterNumbers.Count; i++)
        {
            str1 = str1.Replace(numbers[i].Value, letterAfterNumbers[i].Value);
        }

        Console.WriteLine(str1);
    }
}

