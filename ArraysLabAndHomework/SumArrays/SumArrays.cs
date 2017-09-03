using System;
using System.Linq;
class SumArrays
{
    static void Main()
    {
        var firstNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var secondNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int maxLength = Math.Max(firstNumbers.Length, secondNumbers.Length);

        int minLength = Math.Min(firstNumbers.Length, secondNumbers.Length);

        if (firstNumbers.Length > secondNumbers.Length)
        {
            Array.Resize(ref secondNumbers, firstNumbers.Length);

            for (int i = minLength; i < secondNumbers.Length; i++)
            {
                secondNumbers[i] = secondNumbers[i % minLength];
            }
        }

        else
        {
            Array.Resize(ref firstNumbers, secondNumbers.Length);

            for (int i = minLength; i < firstNumbers.Length; i++)
            {
                firstNumbers[i] = firstNumbers[i % minLength];
            }
        }

        for (int i = 0; i < firstNumbers.Length; i++)
        {
            firstNumbers[i] += secondNumbers[i];
        }

        Console.WriteLine(string.Join(" ", firstNumbers));
    }
}

