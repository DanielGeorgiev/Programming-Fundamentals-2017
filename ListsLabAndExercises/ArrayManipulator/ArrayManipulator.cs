using System;
using System.Collections.Generic;
using System.Linq;
public class ArrayManipulator
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToList();

        var command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        while (command[0] != "print")
        {
            switch (command[0])
            {
                case "add":
                    int index = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    numbers.Insert(index, element);
                    break;

                case "addMany":
                    index = int.Parse(command[1]);
                    AddMany(command, numbers, index);
                    break;

                case "contains":
                    element = int.Parse(command[1]);
                    Contains(numbers, element);
                    break;

                case "remove":
                    index = int.Parse(command[1]);
                    numbers.RemoveAt(index);
                    break;

                case "shift":
                    int positions = int.Parse(command[1]);

                    ShiftingList(positions, numbers);
                    break;

                case "sumPairs":
                    int length = numbers.Count / 2;
                    SumPairs(numbers, length);
                    break;
            }

            command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        }

        Console.WriteLine("[{0}]", string.Join(", ", numbers));
    }

    public static void ShiftingList(int positions, List<int> numbers)
    {
        for (int i = 1; i <= positions; i++)
        {
            int currentNumber = numbers[0];
            numbers.RemoveAt(0);
            numbers.Add(currentNumber);
        }
    }

    public static void SumPairs(List<int> numbers, int length)
    {
        for (int i = 0; i < length; i++)
        {
            numbers[i] += numbers[i + 1];
            numbers.RemoveAt(i + 1);
        }
    }

    public static void AddMany(string[] command, List<int> numbers, int index)
    {
        var range = new List<int>();

        for (int i = 2; i < command.Length; i++)
        {
            range.Add(int.Parse(command[i]));
        }

        numbers.InsertRange(index, range);
    }

    public static void Contains(List<int> numbers, int element)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == element)
            {
                Console.WriteLine(i);
                break;
            }
            else if (numbers[i] != element && i == numbers.Count - 1)
            {
                Console.WriteLine("-1");
            }
        }
    }
}

