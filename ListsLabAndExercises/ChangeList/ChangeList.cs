using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        var command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (command[0] != "Odd" && command[0] != "Even")
        {
            if (command[0] == "Delete")
            {
                var element = int.Parse(command[1]);
                DeleteElement(numbers, element);
            }
            else if (command[0] == "Insert")
            {
                var element = int.Parse(command[1]);
                var position = int.Parse(command[2]);
                numbers.Insert(position, element);
            }

            command = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        }

        if (command[0] == "Odd")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i]) % 2 != 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
        else if (command[0] == "Even")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Abs(numbers[i]) % 2 == 0)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
        }
    }

    public static void DeleteElement(List<int> numbers, int element)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers.Remove(element);
        }
    }
}

