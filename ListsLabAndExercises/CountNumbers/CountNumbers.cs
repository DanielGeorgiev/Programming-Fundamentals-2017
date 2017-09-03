using System;
using System.Collections.Generic;
using System.Linq;
public class CountNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var count = new int[1001];

        foreach (var number in numbers)
        {
            count[number]++;
        }

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] != 0)
            {
                Console.WriteLine("{0} -> {1}", i, count[i]);
            }
        }
    }
}

