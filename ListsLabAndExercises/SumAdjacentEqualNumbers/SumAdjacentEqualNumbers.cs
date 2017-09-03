using System;
using System.Collections.Generic;
using System.Linq;
public class SumAdjacentEqualNumbers
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        var sum = numbers.ToList();

        for (int i = 0; i < sum.Count; i++)
        {
            while (i < numbers.Count - 1)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    numbers[i] += numbers[i + 1];
                    numbers.RemoveAt(i + 1);

                    if (i > 0) 
                    {
                        i--;
                    }
                }
                else
                {
                    i++;
                }
            }
		
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}

