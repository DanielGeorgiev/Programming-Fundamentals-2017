using System;
using System.Collections.Generic;
using System.Linq;
public class InventoryMatcher
{
    public static void Main()
    {
        var products = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        var quantities = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();

        var prices = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        string product = Console.ReadLine();

        while (product != "done")
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (product == products[i])
                {
                    Console.WriteLine("{0} costs: {1}; Available quantity: {2}", products[i], prices[i], quantities[i]);
                }
            }

            product = Console.ReadLine();
        }
    }
}

