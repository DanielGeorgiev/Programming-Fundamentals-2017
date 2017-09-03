using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
public class Program
{
    public static void Main()
    {
        DirectoryInfo folder = new DirectoryInfo("TestFolder");
        var files = folder.GetFiles();
        var sizes = new List<string>();

        for (int i = 0; i < files.Length; i++)
        {
            sizes.Add((files[i].Length / 1000000.0m).ToString() + " MB");
        }

        File.WriteAllLines("TestFolderFilesSizes.txt", sizes);
    }
}

