using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var searchNumber = int.Parse(Console.ReadLine());

        FindLastOccurenceAndSum(numbers, searchNumber);
    }

    public static void FindLastOccurenceAndSum(int[] numbers, int searchNumber)
    {
        long sum = 0;
        bool occurenceFound = false;

        for (int i = numbers.Length - 1; i >= 0; i--)
        {
            if (numbers[i] == searchNumber)
            {
                for (int j = 0; j < i; j++)
                {
                    sum += numbers[j];
                }
                occurenceFound = true;
                break;
            }
        }

        if (occurenceFound)
        {
            Console.WriteLine(sum);
        }
        else
        {
            Console.WriteLine("No occurrences were found!");
        }
    }
}
