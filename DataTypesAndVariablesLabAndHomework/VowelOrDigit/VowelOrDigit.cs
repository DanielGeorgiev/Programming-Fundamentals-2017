using System;
class VowelOrDigit
{
    static void Main()
    {
        char symbol = char.Parse(Console.ReadLine());
        bool isDigit = symbol >= '0' && symbol <= '9';
        bool isVowel = symbol == 'a' || symbol == 'e' || symbol == 'i' || symbol == 'o' || symbol == 'u';

        if (isDigit)
        {
            Console.WriteLine("digit");
        }
        else if (isVowel)
        {
            Console.WriteLine("vowel");
        }
        else
        {
            Console.WriteLine("other");
        }
    }
}

