using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
        var maxSequence = new List<int>();
        var equalElements = 1;
        var maxEqualElements = 0;

        // 1 2 3 4 - 0 1 2 3 
                                 //3 = i
        for (int i = 0; i < numbers.Length; i++)
        {
                                   //j = 2
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    equalElements++;
                }
            }
        }
    }
}

