using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class Censorship
{
    public static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        var replacedText = Regex.Replace(text, word, new string('*', word.Length));

        Console.WriteLine(replacedText);
    }
}
