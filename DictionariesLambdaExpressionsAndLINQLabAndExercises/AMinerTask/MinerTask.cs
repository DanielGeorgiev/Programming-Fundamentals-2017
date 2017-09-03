using System;
using System.Collections.Generic;
using System.Linq;
public class MinerTask
{
    public static void Main()
    {
        var resource = Console.ReadLine();

        var resourceQuantityDict = new Dictionary<string, int>();

        while (resource != "stop")
        {
            var quantity = int.Parse(Console.ReadLine());

            if (resourceQuantityDict.ContainsKey(resource))
            {
                resourceQuantityDict[resource] += quantity;
            }
            else
            {
                resourceQuantityDict[resource] = quantity;
            }
            resource = Console.ReadLine();
        }

        foreach (var item in resourceQuantityDict)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}

