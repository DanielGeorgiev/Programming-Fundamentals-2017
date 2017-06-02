using System;
class ReversedChars
{
    static void Main()
    {
        var charArray = new char[3];
        for (int i = 0; i < 3; i++)
        {
            charArray[i] = char.Parse(Console.ReadLine());
        }

        for (int i = 2; i >= 0; i--)
        {
            Console.Write(charArray[i]);
        }
    }
}

