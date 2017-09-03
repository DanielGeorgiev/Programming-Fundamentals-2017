using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split().Select(int.Parse).ToArray();

        var dict = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            var number = numbers[i];

            if (!dict.ContainsKey(number))
            {
                dict[number] = 0;
            }

            dict[number]++;
        }

        dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

        foreach (var item in dict)
        {
            Console.WriteLine("{0}", item.Key);
            break;
        }
    }
}

