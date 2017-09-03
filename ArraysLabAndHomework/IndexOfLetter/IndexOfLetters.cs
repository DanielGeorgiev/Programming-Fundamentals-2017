using System;
using System.Linq;
class IndexOfLetters
{
    static void Main()
    {
        var characters = Console.ReadLine().ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", characters[i], (int)characters[i] - 'a');
        }
    }
}

