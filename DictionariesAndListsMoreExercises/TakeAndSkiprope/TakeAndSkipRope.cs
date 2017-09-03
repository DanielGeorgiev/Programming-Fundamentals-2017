using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class TakeAndSkipRope
{
    public static void Main()
    {
        string encryptedMessage = Console.ReadLine();

        var numbersList = encryptedMessage.Where(x => (int)x >= 48 && (int)x <= 57).Select(x => x - '0').ToList();
        var nonNumbersList = encryptedMessage.Where(x => (int)x > 57 || (int)x < 48).ToList();

        var takeList = new List<int>();
        var skipList = new List<int>();

        for (int i = 0; i < numbersList.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(numbersList[i]);
            }
            else
            {
                skipList.Add(numbersList[i]);
            }
        }

        var result = new StringBuilder();
        var skipTotal = 0;

        for (int i = 0; i < skipList.Count; i++)
        {
            result.Append(string.Concat(nonNumbersList.Skip(skipTotal).Take(takeList[i])));
            skipTotal += takeList[i] + skipList[i];
        }

        Console.WriteLine(result.ToString());
    }
}

