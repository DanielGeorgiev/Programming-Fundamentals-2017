using System;
using System.Collections.Generic;
using System.Linq;
public class ReverseString
{
    public static void Main()
    {
        var word = Console.ReadLine();
        Console.WriteLine(Reverse(word));
    }
    
    public static string Reverse(string str)
    {
        var charArray = str.Reverse().ToArray();
        var reversedWord = new string(charArray);
        return reversedWord;
    }
}

