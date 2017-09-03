using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class MultiplyBigNumbers
{
    public static void Main()
    {
        string number = Console.ReadLine().TrimStart(new char[] { '0' });
        int multiplier = int.Parse(Console.ReadLine());

        if (number == "0" || multiplier == 0 || number == "")
        {
            Console.WriteLine(0);
            return;
        }

        int product = 0;
        int numberInMind = 0;
        int remainder = 0;

        StringBuilder result = new StringBuilder();

        for (int i = number.Length - 1; i >= 0; i--)
        {
            product = (int.Parse(number[i].ToString()) * multiplier + numberInMind);
            numberInMind = (product / 10);
            remainder = (product % 10);
            result.Append(remainder);
            if (i == 0 && numberInMind != 0)
            {
                result.Append(numberInMind);
            }

        }

        Console.WriteLine(new string(result.ToString().ToArray().Reverse().ToArray()));
    }
}