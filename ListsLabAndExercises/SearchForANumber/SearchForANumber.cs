using System;
using System.Collections.Generic;
using System.Linq;
public class SearchForANumber
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var magicNumbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var updatedNumbers = new List<int>();

        for (int i = 0; i < magicNumbers[0]; i++)
        {
            updatedNumbers.Add(numbers[i]);
        }

        for (int i = 0; i < magicNumbers[1]; i++)
        {
            updatedNumbers[i] = 0;
        }

        bool isFound = false;

        for (int i = magicNumbers[1]; i < updatedNumbers.Count; i++)
        {
            if (updatedNumbers[i] == magicNumbers[2])
            {
                isFound = true;
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }
}

