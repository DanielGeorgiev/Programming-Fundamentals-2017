using System;
using System.Collections.Generic;
using System.Linq;
public class UpgradedMatcher
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
        Array.Resize(ref quantities, products.Length);

        var prices = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        var product = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

        while (product[0] != "done")
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (product[0] == products[i])
                {
                        if (quantities[i] >= long.Parse(product[1]) && quantities[i] != 0)
                        {
                            Console.WriteLine("{0} x {1} costs {2:f2}", product[0], product[1], prices[i] * long.Parse(product[1]));
                            quantities[i] -= long.Parse(product[1]);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("We do not have enough {0}", product[0]);
                            break;
                        }
                }
            }

            product = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

