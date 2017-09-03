using System;
using System.Collections.Generic;
using System.Linq;
public class LargestThreeNumbers
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .OrderByDescending(x => x).Take(3)
            .ToList();

        Console.WriteLine(string.Join(" ", nums));
    }
}
