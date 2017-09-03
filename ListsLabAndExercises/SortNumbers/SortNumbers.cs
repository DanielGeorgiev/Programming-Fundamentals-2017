using System;
using System.Collections.Generic;
using System.Linq;
public class SortNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToList();

        numbers.Sort();

        Console.WriteLine(string.Join(" <= ", numbers));
    }
}

