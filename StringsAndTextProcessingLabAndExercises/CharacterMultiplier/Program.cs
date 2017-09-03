using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split().ToArray();
        var str1 = input[0];
        var str2 = input[1];
        Console.WriteLine(CharacterMuliplier(str1, str2));
    }

    public static long CharacterMuliplier(string str1, string str2)
    {
        var str1Numbers = str1.Select(ch => (int)ch).ToArray();
        var str2Numbers = str2.Select(ch => (int)ch).ToArray();
        long total = 0;

        if (str1Numbers.Length == str2Numbers.Length)
        {
            for (int i = 0; i < str1Numbers.Length; i++)
            {
                total += str1Numbers[i] * str2Numbers[i];
            }
        }
        else
        {
            int minLength = Math.Min(str1Numbers.Length, str2Numbers.Length);
            int maxLength = Math.Max(str1Numbers.Length, str2Numbers.Length);

            for (int i = 0; i < minLength; i++)
            {
                total += str1Numbers[i] * str2Numbers[i];
            }

            for (int i = minLength; i < maxLength; i++)
            {
                if (maxLength == str1Numbers.Length)
                {
                    total += str1Numbers[i];
                }
                else
                {
                    total += str2Numbers[i];
                }
            }
        }

        return total;
    }
}

