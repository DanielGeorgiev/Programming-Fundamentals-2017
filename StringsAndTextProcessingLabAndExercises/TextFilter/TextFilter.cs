using System;
using System.Collections.Generic;
using System.Linq;
public class TextFilter
{
    public static void Main()
    {
        var banList = Console.ReadLine()
            .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine();

        for (int i = 0; i < banList.Length; i++)
        {
            if (text.Contains(banList[i]))
            {
                text = text.Replace(banList[i], new string('*', banList[i].Length));
            }
        }

        Console.WriteLine(text);
    }
}

