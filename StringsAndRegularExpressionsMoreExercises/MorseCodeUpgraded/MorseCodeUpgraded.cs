using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class MorseCodeUpgraded
{
    public static void Main()
    {
        //consecutiveEqual (\d)\1+
        var encodedLetters = Console.ReadLine()
            .Split('|').ToArray();
        var letters = new List<int>();

        //111000001110000|111111110111111111
        for (int i = 0; i < encodedLetters.Length; i++)
        {
            var matches = Regex.Matches(encodedLetters[i], @"(\d)\1+");
            var letterSum = 0;

            if (matches.Count != 0)
            {
                foreach (Match m in matches)
                {
                    var length = m.Value.Length;
                    letterSum += length;
                }
            }

            var zeroesMatches = Regex.Matches(encodedLetters[i], @"0+");
            var onesMatches = Regex.Matches(encodedLetters[i], @"1+");
            var zeroes = 0;
            var ones = 0;

            foreach (Match zero in zeroesMatches)
            {
                zeroes += zero.Length;
            }
            foreach (Match one in onesMatches)
            {
                ones += one.Length;
            }

            letterSum += zeroes * 3 + ones * 5;

            letters.Add(letterSum);
        }

        var decodedLetters = letters.Select(n => (char)n).ToArray();
        Console.WriteLine(string.Join("", decodedLetters));
    }
}

