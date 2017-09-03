using System;
using System.Collections.Generic;
public class PrimesInGivenRange
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine(FindPrimesInGivenRange(start, end));
    }

    public static string FindPrimesInGivenRange(int start, int end)
    {
        var primesInGivenRange = new List<int>();
        bool isPrime = true;

        for (int currentNumber = start; currentNumber <= end; currentNumber++)
        {
            isPrime = true;
            for (int checkCurrentNumber = 2; checkCurrentNumber <= Math.Sqrt(currentNumber); checkCurrentNumber++)
            {
                if (currentNumber % checkCurrentNumber == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && currentNumber != 0 && currentNumber != 1)
            {
                primesInGivenRange.Add(currentNumber);
            }
        }

        return string.Join(", ", primesInGivenRange);
    }
}

