using System;
class StringConcatenation
{
    static void Main()
    {
        char delimiter = char.Parse(Console.ReadLine());
        string evenOrOdd = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        string concatinatedString = string.Empty;

        for (int i = 1; i <= n; i++)
        {
            string word = Console.ReadLine();

            if (evenOrOdd == "even")
            {
                if (i % 2 == 0)
                {
                    concatinatedString += word + delimiter;
                }
            }

            else if (evenOrOdd == "odd")
            {
                if (i % 2 != 0)
                {
                    concatinatedString += word + delimiter;
                }
            }
        }

        Console.WriteLine(concatinatedString.Remove(concatinatedString.Length - 1));
    }
}

