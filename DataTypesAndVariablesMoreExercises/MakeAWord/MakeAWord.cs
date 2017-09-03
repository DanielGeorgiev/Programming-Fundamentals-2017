using System;
class MakeAWord
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = string.Empty;

        for (int i = 0; i < n; i++)
        {
            char character = char.Parse(Console.ReadLine());
            word += character;
        }

        Console.WriteLine("The word is: " + word);
    }
}

