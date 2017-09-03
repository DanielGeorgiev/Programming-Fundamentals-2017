using System;
using System.Linq;
class Program
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        var middleNumbers = new int[0];

        int count = 0;
        
        if (numbers.Length == 1)
        {
            middleNumbers = new int[1];

            middleNumbers[0] = numbers[0];
        }
        else if (numbers.Length % 2 == 0)
        {
            middleNumbers = new int[2];

            for (int i = numbers.Length / 2 - 1; i <= numbers.Length / 2; i++)
            {
                middleNumbers[count] = numbers[i];
                count++;
            }
        }
        else if (numbers.Length % 2 != 0)
        {
            middleNumbers = new int[3];

            for (int i = numbers.Length / 2 - 1; i <= numbers.Length / 2 + 1; i++)
            {
                middleNumbers[count] = numbers[i];
                count++;
            }
        }

        Console.WriteLine("{ " + string.Join(", ", middleNumbers) + " }");

    }
}

