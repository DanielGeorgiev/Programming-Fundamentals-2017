using System;
using System.Collections.Generic;
using System.Linq;
public class SplitByWordCasing
{
    public static void Main()
    {
        var text = Console.ReadLine()
            .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var lowercaseWords = new List<string>();
        var uppercaseWords = new List<string>();
        var mixedcaseWords = new List<string>();

        string wordCase = string.Empty;

        for (int i = 0; i < text.Count; i++)
        {
            string word = text[i];

            CaseWord(word, lowercaseWords, uppercaseWords, mixedcaseWords);
        }

        Console.WriteLine("Lower-case: {0}", string.Join(", ", lowercaseWords));
        Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedcaseWords));
        Console.WriteLine("Upper-case: {0}", string.Join(", ", uppercaseWords));
    }

    public static void CaseWord(string word, List<string> lowercaseWords, List<string> uppercaseWords, List<string> mixedcaseWords)
    {
        var uppercaseLowercaseAndMixedcase = new int[3];

        foreach (var character in word)
        {
            if ((int)character >= 65 && (int)character <= 90)
            {
                uppercaseLowercaseAndMixedcase[0] += 1;
            }
            else if ((int)character >= 97 && (int)character <= 122)
            {
                uppercaseLowercaseAndMixedcase[1] += 1;
            }
            else
            {
                uppercaseLowercaseAndMixedcase[2] += 1;
            }
        }

        if ((uppercaseLowercaseAndMixedcase[0] > 0 && uppercaseLowercaseAndMixedcase[1] > 0 || uppercaseLowercaseAndMixedcase[2] > 0) || uppercaseLowercaseAndMixedcase[2] > 0)
        {
            mixedcaseWords.Add(word);
        }
        else if (uppercaseLowercaseAndMixedcase[0] > 0 && uppercaseLowercaseAndMixedcase[1] == 0 && uppercaseLowercaseAndMixedcase[2] == 0)
        {
            uppercaseWords.Add(word);
        }
        else if (uppercaseLowercaseAndMixedcase[0] == 0 && uppercaseLowercaseAndMixedcase[1] > 0 && uppercaseLowercaseAndMixedcase[2] == 0)
        {
            lowercaseWords.Add(word);
        }
    }
}

