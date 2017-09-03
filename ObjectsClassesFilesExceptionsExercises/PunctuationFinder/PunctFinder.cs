using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        var text = File.ReadAllText("sample_text.txt").ToCharArray().Where(x => x == ',' || x == '!' || x=='?' || x=='.' || x==':');
        Console.WriteLine(string.Join(",", text));
    }
}

