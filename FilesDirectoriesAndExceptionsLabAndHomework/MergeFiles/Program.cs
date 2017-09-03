using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        var array1 = File.ReadAllLines("input1.txt");
        var array2 = File.ReadAllLines("input2.txt");

        var array3 = array1.Concat(array2);

        Console.WriteLine(string.Join("\n", array3));
    }
}

