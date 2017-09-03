using System;
using System.Linq;
using System.Collections.Generic;
class TripleSum
{
    static void Main()
    {
        var numbers = Console.ReadLine()
            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        
        var numberPairs = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int result = numbers[i] + numbers[j];

                for (int k = 0; k < numbers.Length; k++)
                {
                    int sums = 0;

                    if (result == numbers[k])
                    {
                        Console.WriteLine("{0} + {1} == {2}", numbers[i], numbers[j], result);
                        sums++;
                        numberPairs.Add(sums);
                        break;
                    }
                }
            }
        }

        bool isNo = true;

        for (int i = 0; i < numberPairs.Count; i++)
        {
            if (numberPairs[i] != 0)
            {
                isNo = false;
                break;
            }
        }

        if (isNo)
        {
            Console.WriteLine("No");
        }
    }
}
