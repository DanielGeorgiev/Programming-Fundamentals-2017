using System;
using System.Linq;
using System.Collections.Generic;
public class ManipulateArray
{
    public static void Main()
    {
        var words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (command[0] == "Reverse")
            {
                ArrayReverse(words);
            }
            else if (command[0] == "Distinct")
            {
                words = words.Distinct().ToArray();
            }
            else if (command[0] == "Replace")
            {
                ArrayReplace(words, command);
            }
        }

        Console.WriteLine(string.Join(", ", words));
    }

    public static void ArrayReverse(string[] words)
    {
        var reversedArray = new string[words.Length];

        for (int index = 0; index < words.Length / 2; index++)
        {
            string wordIndexSave = words[index];
            words[index] = words[words.Length - 1 - index];
            words[words.Length - 1 - index] = wordIndexSave;
        }
    }

    public static void ArrayReplace(string[] words, string[] commands)
    {
        int index = int.Parse(commands[1]);
        string substituent = commands[2];

        words[index] = substituent;
    }
}

