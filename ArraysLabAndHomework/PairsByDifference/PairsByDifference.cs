using System;
using System.Collections.Generic;
using System.Linq;
class PairsByDifference
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var diff = int.Parse(Console.ReadLine());
        var pairs = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i+1; j < numbers.Length; j++)
            {
                if (Math.Abs(numbers[i] - numbers[j]) == diff)
                {
                    pairs++;
                }
            }
        }

        Console.WriteLine(pairs);
    }
}

