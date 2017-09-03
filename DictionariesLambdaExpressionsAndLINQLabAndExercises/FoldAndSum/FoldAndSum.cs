using System;
using System.Collections.Generic;
using System.Linq;
public class FoldAndSum
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var leftSide = nums.Take(nums.Count / 4).Reverse().ToList();
        nums.Reverse();
        var rightSide = nums.Take(nums.Count / 4).ToList();
        nums.Reverse();

        var firstRow = leftSide.Concat(rightSide).ToList();
        var secondRow = nums.Skip(nums.Count / 4).Take(nums.Count / 2).ToList();

        for (int i = 0; i < firstRow.Count; i++)
        {
            firstRow[i] += secondRow[i];
        }

        Console.WriteLine(string.Join(" ", firstRow));
    }
}

