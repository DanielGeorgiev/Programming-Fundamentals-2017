using System;
using System.Linq;
class CompareCharArrays
{
    static void Main()
    {
        var firstCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        var secondCharArray = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

        int equalLetters = 0;

        var minLength = Math.Min(firstCharArray.Length, secondCharArray.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (firstCharArray[i] < secondCharArray[i])
            {
                Console.WriteLine(firstCharArray);
                Console.WriteLine(secondCharArray);
                break;
            }
            else if (firstCharArray[i] == secondCharArray[i])
            {
                equalLetters++;
            }
            else
            {
                Console.WriteLine(secondCharArray);
                Console.WriteLine(firstCharArray);
                break;
            }
        }

        if (equalLetters == minLength)
        {
            if (minLength == firstCharArray.Length)
            {
                for (int j = 0; j < firstCharArray.Length; j++)
                {
                    Console.Write(firstCharArray[j]);
                }
                Console.WriteLine();
                for (int k = 0; k < secondCharArray.Length; k++)
                {
                    Console.Write(secondCharArray[k]);
                }
            }
            else
            {
                for (int k = 0; k < secondCharArray.Length; k++)
                {
                    Console.Write(secondCharArray[k]);
                }
                Console.WriteLine();
                for (int j = 0; j < firstCharArray.Length; j++)
                {
                    Console.Write(firstCharArray[j]);
                }
            }
        }
    }
}

