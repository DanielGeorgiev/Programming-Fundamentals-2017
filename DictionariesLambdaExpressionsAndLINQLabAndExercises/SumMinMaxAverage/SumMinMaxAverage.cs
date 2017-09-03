﻿using System;
using System.Collections.Generic;
using System.Linq;
public class SumMinMaxAverage
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var numbers = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        Console.WriteLine("Sum = {0}", numbers.Sum());
        Console.WriteLine("Min = {0}", numbers.Min());
        Console.WriteLine("Max = {0}", numbers.Max());
        Console.WriteLine("Average = {0}", numbers.Average());
    }
}

