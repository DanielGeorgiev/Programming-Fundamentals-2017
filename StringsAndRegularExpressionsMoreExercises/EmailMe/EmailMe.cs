using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class EmailMe
{
    public static void Main()
    {
        var email = Console.ReadLine().Trim();
        var matches = Regex.Matches(email, @"([^@]+)");

        var str1 = matches[0].Value;
        var str2 = matches[1].Value;

        var sum1 = 0;

        for (int i = 0; i < str1.Length; i++)
        {
            sum1 += str1[i];
        }

        var sum2 = 0;

        for (int i = 0; i < str2.Length; i++)
        {
            sum2 += str2[i];
        }

        if (sum1 - sum2 >= 0)
        {
            Console.WriteLine("Call her!");
        }
        else
        {
            Console.WriteLine("She is not the one.");
        }
    }
}

