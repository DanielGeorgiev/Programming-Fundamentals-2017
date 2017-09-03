using System;
using System.Collections.Generic;
public class BePositive_broken
{
    // 40/100 - JUDGE , UNFINISHED CODE
    public static void Main()
    {
        int countSequences = int.Parse(Console.ReadLine());

        for (int i = 1; i <= countSequences; i++)
        {
            var input = Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<int>();

            for (int j = 0; j < input.Length; j++)
            {
                int num = int.Parse(input[j]);
                numbers.Add(num);
            }

            bool found = false;

            for (int j = 0; j < numbers.Count; j++)
            {
                int currentNum = numbers[j];

                if (currentNum >= 0)
                {
                    if (found)
                    {
                        Console.Write(' ');
                    }

                    Console.Write(currentNum);

                    found = true;
                }

                else
                {
                    if (currentNum != numbers[numbers.Count - 1])
                    {
                        currentNum += numbers[j + 1];
                    }

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                        numbers.RemoveAt(j);
                    }

                    else
                    {
                        numbers.RemoveAt(j);
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("(empty)");
            }

            Console.WriteLine();
        }
    }
}