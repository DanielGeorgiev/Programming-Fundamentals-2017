using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();

        var dict = new Dictionary<string, int>();
        var dict2 = new Dictionary<string, double>();

        while (input != "stocked")
        {
            var tokens = input.Split(' ');
            var product = tokens[0];
            var price = double.Parse(tokens[1]);
            var quantity = int.Parse(tokens[2]);

            if (!dict.ContainsKey(product))
            {
                dict.Add(product, 0);
            }
            if (!dict2.ContainsKey(product))
            {
                dict2.Add(product, 0.0);
            }

            dict[product] += quantity;
            dict2[product] = price;

            input = Console.ReadLine();
        }

        var grandTotal = 0.0;

        foreach (var productQuantity in dict)
        {
            Console.WriteLine("{0}: ${1:f2} * {2} = ${3:f2}", productQuantity.Key, dict2[productQuantity.Key], productQuantity.Value, dict2[productQuantity.Key] * productQuantity.Value);
            grandTotal += dict2[productQuantity.Key] * productQuantity.Value;
        }

        Console.WriteLine("------------------------------\nGrand Total: ${0:f2}", grandTotal);
    }
}

