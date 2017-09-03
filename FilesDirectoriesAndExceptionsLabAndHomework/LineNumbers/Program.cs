using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        var text = File.ReadAllLines("text.txt").Select((line, i) => i + 1 + ". " + line).ToList();

        File.WriteAllLines("numberedLinesText.txt", text);
    }
}

