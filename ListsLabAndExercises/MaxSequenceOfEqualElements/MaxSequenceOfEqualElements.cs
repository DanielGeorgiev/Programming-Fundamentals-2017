using System;
using System.Linq;
using System.Collections.Generic;
public class MaxSequenceOfEqualElements
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        int start = 0;
        int length = 1;

        int bestStart = 0;
        int bestLength = 0;

        // 1 2 2 3 3 3 4 5
        for (int i = 0; i < nums.Count; i++)
        {
            for (int j = i+1; j < nums.Count; j++)
            {
                if (nums[i] == nums[j])
                {
                    start = i;
                    length++;
                }
                else
                {
                    break;
                }
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }

            length = 1;
        }

        for (int i = bestStart; i < bestStart + bestLength; i++)
        {
            Console.Write("{0} ", nums[i]);
        }
    }
}
