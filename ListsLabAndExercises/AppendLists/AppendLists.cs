using System;
using System.Collections.Generic;
using System.Linq;
public class AppendLists
{
    public static void Main()
    {
        var lists = Console.ReadLine()
            .Split(new char[] { '|', }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        lists.Reverse();

        var result = new List<string>();

        foreach (var list in lists)
        {
            var numbers = list.Split(' ').ToList();

            foreach (var number in numbers)
            {
                if (number != string.Empty)
                {
                    result.Add(number);
                }
            }
        }

        Console.WriteLine(string.Join(" ", result));
    }
}

