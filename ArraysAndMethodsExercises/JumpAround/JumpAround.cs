using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var i = 0;

        var sum = numbers[i];

        var length = numbers.Length - 1;


        while (true)
        {
            if (i + numbers[i] <= length)
            {
                i += numbers[i];
                sum += numbers[i];
            }
            else if (i + numbers[i] >= 0)  
            {
                if (length - 1 - numbers[i] >= 0)
                {
                    i -= numbers[i];
                    sum += numbers[i];
                }

                else
                {
                    break;
                }
            }
        }

        Console.WriteLine(sum);
    }
}

