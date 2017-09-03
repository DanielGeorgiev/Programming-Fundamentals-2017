using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var sequence = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToArray();
        long sum = 0;
        
        while (sequence.Length != 0)
        {
            var index = int.Parse(Console.ReadLine());

            if (index >= 0 && index < sequence.Length)
            {
                var currentNumber = sequence[index];
                sum += currentNumber;
                sequence = sequence.Select(x => x <= currentNumber ? x += currentNumber : x -= currentNumber).ToArray();
                var newSequence = sequence.ToList();
                newSequence.RemoveAt(index);
                sequence = newSequence.ToArray();
            }
            else if (index < 0)
            {
                var currentNumber = sequence[0];
                sum += currentNumber;
                sequence[0] = sequence[sequence.Length - 1];
                sequence = sequence.Select(x => x <= currentNumber ? x += currentNumber : x -= currentNumber).ToArray();
            }
            else if (index >= sequence.Length)
            {
                var currentNumber = sequence[sequence.Length - 1];
                sum += currentNumber;
                sequence[sequence.Length - 1] = sequence[0];
                sequence = sequence.Select(x => x <= currentNumber ? x += currentNumber : x -= currentNumber).ToArray();
            }
        }

        Console.WriteLine(sum);
    }
}

