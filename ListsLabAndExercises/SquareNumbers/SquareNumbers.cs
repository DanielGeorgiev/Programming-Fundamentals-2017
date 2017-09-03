using System;
using System.Linq;
using System.Collections.Generic;
public class SquareNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var squareNumbers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
            {
                squareNumbers.Add(numbers[i]);
            }
        }

        squareNumbers.Sort();
        squareNumbers.Reverse();

        Console.WriteLine(string.Join(" ", squareNumbers));
    }
}

