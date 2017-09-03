using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class BigNumbersSum
{
    public static void Main()
    {
        var input1 = Console.ReadLine().TrimStart('0');
        var input2 = Console.ReadLine().TrimStart('0');

        var result = new StringBuilder();
        var currentNumber = 0;
        var bonusNum = 0;

        if (input2.Length > input1.Length)
        {
            input1 = input1.PadLeft(input2.Length, '0');
        }
        else
        {
            input2 = input2.PadLeft(input1.Length, '0');
        }

        var number1 = input1.Select(x => x - '0').ToArray();
        var number2 = input2.Select(x => x - '0').ToArray();

        for (int i = number1.Length - 1; i >= 0; i--)
        {
            currentNumber = number1[i] + number2[i] + bonusNum;
            bonusNum = 0;

            if (currentNumber >= 10 && i != 0)
            {
                result.Append(currentNumber % 10);
                bonusNum = currentNumber / 10;
            }
            else
            {
                var reversedCurrentNumber = new string(currentNumber.ToString().ToCharArray().Reverse().ToArray());
                result.Append(reversedCurrentNumber);
            }
        }

        for (int i = 0; i < result.Length / 2; i++)
        {
            var saveIndex = result[result.Length - 1 - i];
            result[result.Length - 1 - i] = result[i];
            result[i] = saveIndex;
        }

        Console.WriteLine(result);
    }
}

