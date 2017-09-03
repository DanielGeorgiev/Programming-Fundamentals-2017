using System;
using System.Collections.Generic;
using System.Linq;
public class Ladybugs
{
    public static void Main()
    {
        short sizeOfField = short.Parse(Console.ReadLine());
        var field = new int[sizeOfField].ToList();

        var indexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        for (int i = indexes[0]; i <= indexes[indexes.Count - 1]; i++)
        {
            field[i]++;
        }

        var command = Console.ReadLine()
            .Split()
            .ToList();

        while (command[0] != "end")
        {
            if (command[1] == "right")
            {
                int ladybugIndex = int.Parse(command[0]);
                int flyLength = int.Parse(command[2]);

                if (field[ladybugIndex] == 1)
                {
                    for (int i = ladybugIndex; i < flyLength; i++)
                    {
                        if (field[i] == field[i+1])
                        {
                            int currentNumber = field[i];
                            field[i]--;
                            field[i + 2]++;
                        }
                    }
                }
            }

        }
    }
}

