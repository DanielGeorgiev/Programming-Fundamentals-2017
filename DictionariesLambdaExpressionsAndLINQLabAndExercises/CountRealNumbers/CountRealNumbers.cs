using System;
using System.Collections.Generic;
using System.Linq;
public class CountRealNumbers
{
    public static void Main()
    {
        var nums = Console.ReadLine()
            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToList();

        var sortedDict = new SortedDictionary<double, int>();

        foreach (var num in nums)
        {
            if (sortedDict.ContainsKey(num))
            {
                sortedDict[num]++;
            }
            else
            {
                sortedDict[num] = 1;
            }
        }

        foreach (var item in sortedDict)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}
