using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public static void Main()
    {
        string characters = Console.ReadLine();

        for (int i = 0; i < characters.Length; i++)
        {
            Console.WriteLine("{0} -> {1}", characters[i], characters[i] - 'a');
        }
    }
}

