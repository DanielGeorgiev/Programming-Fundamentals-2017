using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split().Select(n => int.Parse(n)).ToArray();

        int start = 0;
        int length = 1;

        int bestStart = 0;
        int bestLength = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    start = i;
                    length = j + 1;
                }
                else
                {
                    break;
                }
            }

            if (length - start >= bestLength)
            {
                bestStart = start;
                bestLength = length;
            }

            length = 0;
            start = 0;
        }

        for (int i = bestStart; i < bestLength; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    }
}

