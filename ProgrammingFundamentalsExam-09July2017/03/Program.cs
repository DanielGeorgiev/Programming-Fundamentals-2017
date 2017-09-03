using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

public class Program
{
    public static void Main()
    {
        var pokeword = Console.ReadLine();

        while (pokeword.Length != 0)
        {
            var didiMatch = Regex.Match(pokeword, @"([^a-zA-Z-]+)");

            if (didiMatch.Success)
            {
                Console.WriteLine(didiMatch.Value);
                pokeword = pokeword.Substring(didiMatch.Index + didiMatch.Length, pokeword.Length - didiMatch.Index - didiMatch.Length);

                var bojoMatch = Regex.Match(pokeword, @"[a-zA-Z]+-[a-zA-Z]+");
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value);
                    var length = pokeword.Length - bojoMatch.Index - bojoMatch.Length;
                    pokeword = pokeword.Substring(bojoMatch.Index + bojoMatch.Length, length);
                }
                else
                {
                    break;
                }
            }
            else
            {
                break;
            }
        }
    }
}