using System;
using System.Collections.Generic;
using System.Linq;
public class ByteFlip
{
    public static void Main()
    {
        var line = Console.ReadLine()
            .Split().Where(x => x.Length == 2)
            .Select(x => Reverse(x))
            .Reverse()
            .Select(x => Convert.ToInt32(x, 16))
            .ToList();

        for (int i = 0; i < line.Count; i++)
        {
            Console.Write((char)line[i]);
        }
        Console.WriteLine();
    }

    public static string Reverse(string x)
    {
        char[] charArray = x.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

