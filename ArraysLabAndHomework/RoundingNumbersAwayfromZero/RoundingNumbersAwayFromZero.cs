using System;
using System.Linq;
class RoundingNumbersAwayFromZero
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine("{0} => {1}", numbers[i], Math.Round(numbers[i], MidpointRounding.AwayFromZero));
        }
    }
}

