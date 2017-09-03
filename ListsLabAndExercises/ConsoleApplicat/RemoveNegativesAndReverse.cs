using System;
using System.Linq;
using System.Collections.Generic;
class RemoveNegativesAndReverse
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] < 0)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }

        numbers.Reverse();

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

