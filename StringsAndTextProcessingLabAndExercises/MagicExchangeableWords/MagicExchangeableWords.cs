using System;
using System.Collections.Generic;
using System.Linq;
public class MagicExchangeableWords
{
    public static void Main()
    {
        var words = Console.ReadLine()
            .Split();
        var word1 = words[0];
        var word2 = words[1];
        var isExchangeable = IsExchangeable(word1, word2);

        if (isExchangeable)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }

    public static bool IsExchangeable(string word1, string word2)
    {
        var distinctedW1 = new string(word1.Distinct().ToArray());
        var distincedW2 = new string(word2.Distinct().ToArray());

        if (distinctedW1.Length == distincedW2.Length)
        {
            return true;
        }

        return false;
    }
}

