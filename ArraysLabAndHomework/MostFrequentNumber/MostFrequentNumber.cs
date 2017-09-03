using System;
using System.Linq;
public class MostFrequentNumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var frequentNumbers = numbers.ToArray();

        var counter = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = counter; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    frequentNumbers[i] += Math.Abs(numbers[i]);
                }
            }

            if (numbers[i] == 0)
            {
                frequentNumbers[i] /= 1;
            }
            else
            {
                frequentNumbers[i] /= Math.Abs(numbers[i]);
            }


            counter++;
        }

        int frequentNumber = frequentNumbers.Max();
        int frequentNumberIndex = frequentNumbers.ToList().IndexOf(frequentNumber);

        Console.WriteLine(numbers[frequentNumberIndex]);
    }
}