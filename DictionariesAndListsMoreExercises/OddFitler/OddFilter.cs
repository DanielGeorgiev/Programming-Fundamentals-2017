using System;
using System.Collections.Generic;
using System.Linq;
public class OddFilter
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Where(x => x % 2 == 0).ToList();
        double average = nums.Average();

        nums = nums.Select(x =>  (x > average) ? x+=1 : x-=1).ToList();

        Console.WriteLine(string.Join(" ", nums));
    }
}

