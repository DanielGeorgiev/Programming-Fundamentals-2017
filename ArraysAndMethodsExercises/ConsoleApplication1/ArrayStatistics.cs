using System;
using System.Linq;
public class ArrayStatistics
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine("Min = {0}", ArrayMin(numbers));
        Console.WriteLine("Max = {0}", ArrayMax(numbers));
        Console.WriteLine("Sum = {0}", ArraySum(numbers));
        Console.WriteLine("Average = {0}", ArrayAverage(numbers));
    }

    public static int ArrayMin(int[] numbers)
    {
        int min = int.MaxValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        return min;
    }

    public static int ArrayMax(int[] numbers)
    {
        int max = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        return max;
    }

    public static double ArraySum(int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;
    }

    public static double ArrayAverage(int[] numbers)
    {
        return (double)(ArraySum(numbers) / numbers.Length);
    }
}

