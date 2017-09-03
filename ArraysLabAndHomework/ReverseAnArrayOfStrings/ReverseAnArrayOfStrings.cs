using System;
class ReverseAnArrayOfStrings
{
    static void Main()
    {
        var words = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var reversedWords = new string[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            reversedWords[i] = words[words.Length - i - 1];
        }

        Console.WriteLine(string.Join(" ", reversedWords));
    }
}

