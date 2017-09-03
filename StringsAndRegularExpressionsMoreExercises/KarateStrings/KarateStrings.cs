using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
public class KarateStrings
{
    public static void Main()
    {
        var str1 = Console.ReadLine();
        int power = 0;

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] == '>')
            {
                power += int.Parse(str1[i + 1].ToString());

                i++;

                while (i < str1.Length && power > 0)
                {
                    if (str1[i] == '>')
                    {
                        break;
                    }
                    str1 = str1.Remove(i, 1);
                    power--;
                }

                i--;
            }
        }

        Console.WriteLine(str1);
    }
}

