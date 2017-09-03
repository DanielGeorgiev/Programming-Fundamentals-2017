using System;
using System.Collections.Generic;
using System.Linq;
public class SortTimes
{
    public static void Main()
    {
        var times = Console.ReadLine()
            .Split()
            .ToList().OrderBy(x => x);

        Console.WriteLine(string.Join(", ", times));
    }
}

