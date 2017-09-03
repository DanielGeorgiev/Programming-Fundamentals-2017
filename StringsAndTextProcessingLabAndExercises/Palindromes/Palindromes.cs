using System;
using System.Collections.Generic;
using System.Linq;
public class Palindromes
{
    public static void Main()
    {
        var text = Console.ReadLine()
            .Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

        var palindromes = new List<string>();

        foreach (var word in text)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        palindromes = palindromes.OrderBy(str => str).Distinct().ToList();

        Console.WriteLine(string.Join(", ", palindromes));
    }

    public static bool IsPalindrome(string word)
    {
        var reversedWord = new string(word.Reverse().ToArray());

        if (word.CompareTo(reversedWord) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

