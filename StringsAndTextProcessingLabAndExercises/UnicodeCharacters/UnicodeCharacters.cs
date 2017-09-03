using System;
using System.Collections.Generic;
using System.Linq;
public class UnicodeCharacters
{
    public static void Main()
    {
        var characters = Console.ReadLine()
            .Select(ch => (int)ch).ToArray();

        for (int i = 0; i < characters.Length; i++)
        {
            Console.Write(@"\u{0:x4}", characters[i]); 
        }
    }
}

