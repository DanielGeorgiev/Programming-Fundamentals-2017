using System;
using System.Collections.Generic;
using System.Linq;
public class SumReversedNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        var sum = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            var charArray = numbers[i].ToCharArray();
            Array.Reverse(charArray);
            int number = int.Parse(new string(charArray));
            sum += number;
        }

        Console.WriteLine(sum);
    }
}

