using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        var text = File.ReadAllLines("text.txt");

        for (int i = 0; i < text.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}

