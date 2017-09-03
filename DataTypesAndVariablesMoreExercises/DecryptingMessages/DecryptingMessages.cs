using System;
class DecryptingMessages
{
    static void Main()
    {
        int decryptingKey = int.Parse(Console.ReadLine());
        int count = int.Parse(Console.ReadLine());
        string decryptedWord = string.Empty;

        for (int i = 0; i < count; i++)
        {
            char character = char.Parse(Console.ReadLine());
            character += (char)decryptingKey;
            decryptedWord += character;
        }

        Console.WriteLine(decryptedWord);
    }
}

