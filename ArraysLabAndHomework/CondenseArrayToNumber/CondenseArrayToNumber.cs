using System;
using System.Linq;
class CondenseArrayToNumber
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        while (numbers.Length > 1)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i != numbers.Length - 1)
                {
                    numbers[i] += numbers[i + 1];
                }
            }

            Array.Resize(ref numbers, numbers.Length - 1);
        }

        Console.WriteLine(numbers[0]);
    }
}

